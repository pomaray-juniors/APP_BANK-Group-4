using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace APP_BANK.Cajero
{
    public partial class BusquedaCliente : Form
    {
        private ConexionDB dbConnection = new ConexionDB();
        

        public BusquedaCliente()
        {
            InitializeComponent();
        }

        private void textBoxCustom1__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            int numeroCuenta;
            if (int.TryParse(textBoxCustom1.Texts, out numeroCuenta))
            {
                ConexionDB dbConnection = new ConexionDB();
                DataTable clienteData = dbConnection.BuscarClientePorNumeroCuenta(numeroCuenta);

                if (clienteData.Rows.Count > 0)
                {
                    DataRow row = clienteData.Rows[0];
                    label1.Text = row["NOMBRE"].ToString();
                    label2.Text = row["MONTO"].ToString();
                    label5.Text = row["EMAIL"].ToString();
                    label6.Text = row["TELEFONO"].ToString();
                    label7.Text = row["CEDULA"].ToString();
                    label8.Text = row["TIPO_CUENTA"].ToString();
                    guna2GradientPanel1.Visible = true;
                    roundButton4.Size = new Size(916, 513);

                }
                else
                {
                    guna2GradientPanel1.Visible = false;
                    roundButton4.Size = new Size(916, 213);
                    MessageBox.Show("Número de cuenta no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un número de cuenta válido.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
