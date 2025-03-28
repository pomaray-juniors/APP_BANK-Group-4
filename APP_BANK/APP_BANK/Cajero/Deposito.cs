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
    public partial class Deposito : Form
    {
        private ConexionDB dbConnection = new ConexionDB();

        public Deposito()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool cambioGeneral = false;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cambioGeneral) return; 

            if (checkBox1.Checked)
            {

                cambioGeneral = true;
                checkBox2.Checked = false;
                roundButton1.Location = new Point(46, 350);
                cambioGeneral = false;

                textBoxCustom1.Visible = false;
                label6.Visible = false;
            }
            else
            {

                cambioGeneral = true;
                checkBox1.Checked = true;
                cambioGeneral = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cambioGeneral) return;

            if (checkBox2.Checked)
            {

                cambioGeneral = true;
                checkBox1.Checked = false;
                roundButton1.Location = new Point(46, 430);
                cambioGeneral = false;

                textBoxCustom1.Visible = true;
                label6.Visible = true;
            }
            else
            {

                cambioGeneral = true;
                checkBox2.Checked = true;
                cambioGeneral = false;
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            int cuentaDestino;
            decimal monto;

            if (!int.TryParse(textBoxCustom2.Texts, out cuentaDestino))
            {
                MessageBox.Show("Ingrese un número de cuenta válido.");
                return;
            }

            if (!decimal.TryParse(textBoxCustom3.Texts, out monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido mayor a 0.");
                return;
            }

            string tipoDeposito = checkBox1.Checked ? "Efectivo" : "Cheque";
            string numeroCheque = tipoDeposito == "Cheque" ? textBoxCustom1.Texts : null;

            bool resultado = dbConnection.RealizarDeposito(cuentaDestino, monto, tipoDeposito, numeroCheque);

            if (resultado)
            {
                MessageBox.Show("Depósito realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Error al realizar el depósito. Verifique la cuenta de destino.");
            }

        }

        private void roundButton4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCustom1__TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCustom3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada si no es número
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}