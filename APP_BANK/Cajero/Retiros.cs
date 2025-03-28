using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_BANK.Cajero
{
    public partial class Retiros : Form
    {
        private ConexionDB dbConnection = new ConexionDB();

        public Retiros()
        {
            InitializeComponent();
        }

        private void textBoxCustom3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada si no es número
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            int numeroCuenta, cedulaCliente;
            decimal monto;

            // Validar que los TextBox no estén vacíos
            if (string.IsNullOrWhiteSpace(textBoxCustom2.Texts) ||
                string.IsNullOrWhiteSpace(textBoxCustom3.Texts) ||
                string.IsNullOrWhiteSpace(textBoxCustom1.Texts))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar conversión de Cuenta de Origen
            if (!int.TryParse(textBoxCustom2.Texts, out numeroCuenta))
            {
                MessageBox.Show("El número de cuenta debe ser un valor numérico válido.");
                return;
            }

            // Validar conversión de Monto
            if (!decimal.TryParse(textBoxCustom3.Texts, out monto) || monto <= 0)
            {
                MessageBox.Show("El monto debe ser un número positivo.");
                return;
            }

            // Validar conversión de Cédula
            if (!int.TryParse(textBoxCustom1.Texts, out cedulaCliente))
            {
                MessageBox.Show("La cédula debe ser un valor numérico válido.");
                return;
            }

            bool retiroExitoso = dbConnection.RealizarRetiro(numeroCuenta, monto, cedulaCliente);

            if (retiroExitoso)
            {
                MessageBox.Show("Retiro realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Error en el retiro: cuenta no válida, saldo insuficiente o número de cédula incorrecto.");
            }
        }

        private void textBoxCustom1__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
