using System;
using System.Collections.Generic;
using System.Data;
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


        private SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }


        // Método para verificar las credenciales (nombre y contraseña)
        public (bool usuarioValido, string rol, string error) VerificarUsuario(string nombre, string contrasena)
        {
            bool usuarioValido = false;
            string rol = "";
            string error = "";

            try
            {
                string query = "SELECT ROL FROM PERSONAL WHERE NOMBRE COLLATE Latin1_General_CS_AS = @Nombre AND CONTRASEÑA COLLATE Latin1_General_CS_AS = @Contrasena";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre.Trim());
                        command.Parameters.AddWithValue("@Contrasena", contrasena.Trim());

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            usuarioValido = true;
                            rol = result.ToString().Trim();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return (usuarioValido, rol, error);
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

        public bool RealizarDeposito(int cuentaDestino, decimal monto, string tipoDeposito, string numeroCheque = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Verificar si la cuenta de destino existe
                string verificarCuentaQuery = "SELECT COUNT(*) FROM CUENTA WHERE NUMERO_CUENTA = @CuentaDestino";
                using (SqlCommand verificarCuentaCmd = new SqlCommand(verificarCuentaQuery, connection))
                {
                    verificarCuentaCmd.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
                    int cuentaExiste = (int)verificarCuentaCmd.ExecuteScalar();

                    if (cuentaExiste == 0)
                    {
                        return false; // La cuenta no existe
                    }
                }

                // Insertar la transacción en la tabla TRANSACCIONES
                string insertarTransaccionQuery = @"
            INSERT INTO TRANSACCIONES (MONTO, TIPO_TRANSACCION, DESCRIPCION, NUMERO_CUENTA)
            VALUES (@Monto, @TipoTransaccion, @Descripcion, @CuentaDestino)";

                using (SqlCommand insertarTransaccionCmd = new SqlCommand(insertarTransaccionQuery, connection))
                {
                    insertarTransaccionCmd.Parameters.AddWithValue("@Monto", monto);
                    insertarTransaccionCmd.Parameters.AddWithValue("@TipoTransaccion", "Depósito");
                    insertarTransaccionCmd.Parameters.AddWithValue("@Descripcion", tipoDeposito == "Cheque" ? $"Depósito con cheque: {numeroCheque}" : "Depósito en efectivo");
                    insertarTransaccionCmd.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);

                    int filasAfectadas = insertarTransaccionCmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        // Actualizar el saldo de la cuenta
                        string actualizarSaldoQuery = "UPDATE CUENTA SET MONTO = MONTO + @Monto WHERE NUMERO_CUENTA = @CuentaDestino";
                        using (SqlCommand actualizarSaldoCmd = new SqlCommand(actualizarSaldoQuery, connection))
                        {
                            actualizarSaldoCmd.Parameters.AddWithValue("@Monto", monto);
                            actualizarSaldoCmd.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
                            actualizarSaldoCmd.ExecuteNonQuery();
                        }
                        return true; // Depósito exitoso
                    }
                }
            }
            return false; // Falló la inserción
        }

        public bool RealizarRetiro(int numeroCuenta, decimal monto, int cedulaCliente)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                // Verificar que la cuenta existe y pertenece al cliente
                string consultaCuenta = "SELECT MONTO FROM CUENTA WHERE NUMERO_CUENTA = @NumeroCuenta AND CEDULA = @Cedula";
                using (SqlCommand cmd = new SqlCommand(consultaCuenta, conexion))
                {
                    cmd.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                    cmd.Parameters.AddWithValue("@Cedula", cedulaCliente);

                    object resultado = cmd.ExecuteScalar();
                    if (resultado == null)
                    {
                        return false; // La cuenta no existe o no pertenece al cliente
                    }

                    decimal saldoActual = Convert.ToDecimal(resultado);

                    // Verificar si hay suficiente saldo
                    if (saldoActual < monto)
                    {
                        return false; // Fondos insuficientes
                    }
                }

                // Insertar la transacción
                string insertarTransaccion = @"
            INSERT INTO TRANSACCIONES (MONTO, TIPO_TRANSACCION, DESCRIPCION, NUMERO_CUENTA) 
            VALUES (@Monto, 'Retiro', 'Retiro en efectivo', @NumeroCuenta)";
                using (SqlCommand cmdInsert = new SqlCommand(insertarTransaccion, conexion))
                {
                    cmdInsert.Parameters.AddWithValue("@Monto", monto);
                    cmdInsert.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                    cmdInsert.ExecuteNonQuery();
                }

                // Actualizar el saldo de la cuenta
                string actualizarCuenta = "UPDATE CUENTA SET MONTO = MONTO - @Monto WHERE NUMERO_CUENTA = @NumeroCuenta";
                using (SqlCommand cmdUpdate = new SqlCommand(actualizarCuenta, conexion))
                {
                    cmdUpdate.Parameters.AddWithValue("@Monto", monto);
                    cmdUpdate.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                    cmdUpdate.ExecuteNonQuery();
                }

                return true; // Retiro exitoso
            }
        }

        public DataTable BuscarClientePorNumeroCuenta(int numeroCuenta)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT c.CEDULA, c.NOMBRE, c.APELLIDO, c.EMAIL, c.TELEFONO, cu.MONTO, cu.TIPO_CUENTA
                FROM CLIENTE c
                JOIN CUENTA cu ON c.CEDULA = cu.CEDULA
                WHERE cu.NUMERO_CUENTA = @NumeroCuenta";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable ObtenerDatosUsuario(int cedula)
        {
            string query = @"
        SELECT 
            C.NOMBRE + ' ' + C.APELLIDO AS NOMBRE_COMPLETO, 
            C.EMAIL, 
            C.TELEFONO, 
            C.DIRECCION, 
            CU.TIPO_CUENTA, 
            CU.NUMERO_CUENTA, 
            CU.MONTO
        FROM CLIENTE C
        JOIN CUENTA CU ON C.CEDULA = CU.CEDULA
        WHERE C.CEDULA = @Cedula";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Cedula", cedula);
                    conexion.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public bool ActualizarDatosUsuario(int cedula, string email, string telefono, string direccion)
        {
            string query = @"
        UPDATE CLIENTE 
        SET EMAIL = @Email, 
            TELEFONO = @Telefono, 
            DIRECCION = @Direccion
        WHERE CEDULA = @Cedula";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Cedula", cedula);
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@Telefono", telefono);
                    comando.Parameters.AddWithValue("@Direccion", direccion);

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public void InsertarUsuario(int cedula, string nombre, string apellido, string email, string telefono, string direccion, string tipoCuenta, decimal monto, int numeroCuenta)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    // Verificar si la cédula ya existe en CLIENTE
                    string verificarCliente = "SELECT COUNT(*) FROM CLIENTE WHERE CEDULA = @Cedula";
                    using (SqlCommand cmdVerificar = new SqlCommand(verificarCliente, conexion, transaccion))
                    {
                        cmdVerificar.Parameters.AddWithValue("@Cedula", cedula);
                        int existeCliente = (int)cmdVerificar.ExecuteScalar();

                        if (existeCliente > 0)
                        {
                            throw new Exception("El cliente con la cédula " + cedula + " ya existe en la base de datos.");
                        }
                    }

                    // Insertar en CLIENTE
                    string queryCliente = @"
                INSERT INTO CLIENTE (CEDULA, NOMBRE, APELLIDO, EMAIL, TELEFONO, DIRECCION)
                VALUES (@Cedula, @Nombre, @Apellido, @Email, @Telefono, @Direccion);";

                    using (SqlCommand cmdCliente = new SqlCommand(queryCliente, conexion, transaccion))
                    {
                        cmdCliente.Parameters.AddWithValue("@Cedula", cedula);
                        cmdCliente.Parameters.AddWithValue("@Nombre", nombre);
                        cmdCliente.Parameters.AddWithValue("@Apellido", apellido);
                        cmdCliente.Parameters.AddWithValue("@Email", email);
                        cmdCliente.Parameters.AddWithValue("@Telefono", telefono);
                        cmdCliente.Parameters.AddWithValue("@Direccion", direccion);
                        cmdCliente.ExecuteNonQuery();
                    }

                    // Insertar en CUENTA
                    string queryCuenta = @"
                INSERT INTO CUENTA (NUMERO_CUENTA, TIPO_CUENTA, MONTO, FECHA_APERTURA, CEDULA)
                VALUES (@NumeroCuenta, @TipoCuenta, @Monto, GETDATE(), @Cedula);";

                    using (SqlCommand cmdCuenta = new SqlCommand(queryCuenta, conexion, transaccion))
                    {
                        cmdCuenta.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                        cmdCuenta.Parameters.AddWithValue("@TipoCuenta", tipoCuenta);
                        cmdCuenta.Parameters.AddWithValue("@Monto", monto);
                        cmdCuenta.Parameters.AddWithValue("@Cedula", cedula);
                        cmdCuenta.ExecuteNonQuery();
                    }

                    transaccion.Commit(); // Confirmar cambios
                }
                catch (Exception ex)
                {
                    transaccion.Rollback(); // Deshacer cambios en caso de error
                    MessageBox.Show("Error al insertar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool ExisteCedula(int cedula)
        {
            bool existe = false;
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT COUNT(*) FROM CLIENTE WHERE CEDULA = @Cedula";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        existe = true;
                    }
                }
            }
            return existe;
        }




    }
}
    