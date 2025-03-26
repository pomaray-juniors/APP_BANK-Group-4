using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP_BANK.Cajero;
using APP_BANK.ServicioAlCliente;

namespace APP_BANK
{
    internal class ConexionDB
    {
        private readonly string connectionString = "Server=Ramerlin;Database=APP_BANCO;Trusted_Connection=True;";

        // Método para verificar las credenciales (nombre y contraseña)
        public bool VerificarUsuario(string nombre, string contrasena)
        {
            bool usuarioValido = false;

            try
            {
                // Consulta que cuenta cuántos registros cumplen la condición
                string query = "SELECT COUNT(*) FROM PERSONAL WHERE NOMBRE = @Nombre AND CONTRASEÑA = @Contrasena";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Usa Trim() para eliminar espacios en blanco extras
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Contrasena", contrasena);

                        int count = (int)command.ExecuteScalar();  // Devuelve el número de registros encontrados

                        if (count > 0)
                        {
                            usuarioValido = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en VerificarUsuario: " + ex.Message);
            }

            return usuarioValido;
        }

        public bool RealizarTransferencia(int cuentaOrigen, int cuentaDestino, decimal monto, string descripcion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlTransaction transaccion = conn.BeginTransaction())
                {
                    try
                    {
                        // Verificar si las cuentas existen
                        string verificarCuentas = "SELECT COUNT(*) FROM CUENTA WHERE NUMERO_CUENTA IN (@CuentaOrigen, @CuentaDestino)";
                        using (SqlCommand cmdVerificar = new SqlCommand(verificarCuentas, conn, transaccion))
                        {
                            cmdVerificar.Parameters.AddWithValue("@CuentaOrigen", cuentaOrigen);
                            cmdVerificar.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
                            int cuentasEncontradas = (int)cmdVerificar.ExecuteScalar();

                            if (cuentasEncontradas < 2)
                            {
                                transaccion.Rollback();
                                return false; // Una de las cuentas no existe
                            }
                        }

                        // Verificar saldo de la cuenta de origen
                        string consultaSaldo = "SELECT MONTO FROM CUENTA WHERE NUMERO_CUENTA = @CuentaOrigen";
                        using (SqlCommand cmdSaldo = new SqlCommand(consultaSaldo, conn, transaccion))
                        {
                            cmdSaldo.Parameters.AddWithValue("@CuentaOrigen", cuentaOrigen);
                            decimal saldoActual = (decimal)cmdSaldo.ExecuteScalar();

                            if (saldoActual < monto)
                            {
                                transaccion.Rollback();
                                return false; // Saldo insuficiente
                            }
                        }

                        // Restar monto de la cuenta de origen
                        string restarMonto = "UPDATE CUENTA SET MONTO = MONTO - @Monto WHERE NUMERO_CUENTA = @CuentaOrigen";
                        using (SqlCommand cmdRestar = new SqlCommand(restarMonto, conn, transaccion))
                        {
                            cmdRestar.Parameters.AddWithValue("@Monto", monto);
                            cmdRestar.Parameters.AddWithValue("@CuentaOrigen", cuentaOrigen);
                            cmdRestar.ExecuteNonQuery();
                        }

                        // Sumar monto a la cuenta de destino
                        string sumarMonto = "UPDATE CUENTA SET MONTO = MONTO + @Monto WHERE NUMERO_CUENTA = @CuentaDestino";
                        using (SqlCommand cmdSumar = new SqlCommand(sumarMonto, conn, transaccion))
                        {
                            cmdSumar.Parameters.AddWithValue("@Monto", monto);
                            cmdSumar.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
                            cmdSumar.ExecuteNonQuery();
                        }

                        // Insertar la transacción en la tabla TRANSACCIONES
                        string insertarTransaccion = "INSERT INTO TRANSACCIONES (MONTO, TIPO_TRANSACCION, DESCRIPCION, NUMERO_CUENTA, NUMERO_CUENTA_DESTINO) VALUES (@Monto, 'Transferencia', @Descripcion, @CuentaOrigen, @CuentaDestino)";
                        using (SqlCommand cmdInsertar = new SqlCommand(insertarTransaccion, conn, transaccion))
                        {
                            cmdInsertar.Parameters.AddWithValue("@Monto", monto);
                            cmdInsertar.Parameters.AddWithValue("@Descripcion", descripcion);
                            cmdInsertar.Parameters.AddWithValue("@CuentaOrigen", cuentaOrigen);
                            cmdInsertar.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
                            cmdInsertar.ExecuteNonQuery();
                        }

                        // Confirmar la transacción
                        transaccion.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                        return false;
                    }
                }
            }
        }


    }
}
    