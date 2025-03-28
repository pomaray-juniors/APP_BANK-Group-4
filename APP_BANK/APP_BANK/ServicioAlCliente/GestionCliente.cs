using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_BANK.ServicioAlCliente
{
    public partial class GestionCliente : Form
    {
        ConexionDB conexion = new ConexionDB();
        public GestionCliente()
        {
            InitializeComponent();
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCustom2.Texts, out int cedula))
            {
                
                DataTable datos = conexion.ObtenerDatosUsuario(cedula);

                if (datos.Rows.Count > 0)
                {
                    DataRow row = datos.Rows[0];

                    // Asignar valores a los TextBox
                    textBox1.Text = row["EMAIL"].ToString();
                    textBox2.Text = row["TELEFONO"].ToString();
                    textBox4.Text = row["DIRECCION"].ToString();

                    // Asignar valores a los Label
                    label1.Text = row["NOMBRE_COMPLETO"].ToString();  // Nombre y Apellido concatenados
                    label8.Text = row["TIPO_CUENTA"].ToString();
                    label9.Text = row["NUMERO_CUENTA"].ToString();
                    label10.Text = row["MONTO"].ToString();

                    // Mostrar el panel con los datos
                    guna2Panel1.Visible = true;
                    roundButton4.Size = new Size(919, 548);
                }
                else
                {
                    guna2Panel1.Visible = false;
                    roundButton4.Size = new Size(916, 183);
                    MessageBox.Show("Usuario no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cédula válida.");
            }
        }

        private void roundButton3_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCustom2.Texts, out int cedula))
            {
                string email = textBox1.Text;
                string telefono = textBox2.Text;
                string direccion = textBox4.Text;

                
                bool actualizado = conexion.ActualizarDatosUsuario(cedula, email, telefono, direccion);

                if (actualizado)
                {
                    MessageBox.Show("Datos actualizados correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario. Verifique la cédula.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cédula válida.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCustom1__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
