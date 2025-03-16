using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_BANK.Cajero
{
    public partial class Login : Form
    {
        
        private int moveAmount = 15; // Velocidad de la animación
        private int targetPosition; // Posición a la que se moverá la imagen
        public Login()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel1.Visible = false;
            

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCustom1__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            if (textBoxCustom1.Texts == "admin" && textBoxCustom2.Texts == "admin")
            {

                AbrirFromMadre(new homeCajero());
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            
            AbrirFromMadre(new Perfiles());



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool EsCorreoValido(string email)
        {
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patronCorreo);
        }

        private void textBoxCustom3__TextChanged(object sender, EventArgs e)
        {


            string email = textBoxCustom3.Texts;
            if (EsCorreoValido(email))
            {

                textBoxCustom3.BorderColor = Color.Green;
                textBoxCustom3.BorderFocusColor = Color.Green;


                textBoxCustom3.Invalidate();
                textBoxCustom3.Update();

                roundButton5.Enabled = true;
                roundButton5.BackColor = Color.FromArgb(29, 78, 216);
                pictureBox4.BackColor = Color.FromArgb(29, 78, 216);
                
            }
            else
            {
                roundButton5.Enabled = false;
                roundButton5.BackColor = Color.FromArgb(146, 177, 245);
                pictureBox4.BackColor = Color.FromArgb(146, 177, 245);
                textBoxCustom3.BorderColor = Color.Red;
                textBoxCustom3.Refresh();

            };

            

            this.BeginInvoke((MethodInvoker)delegate
            {

                textBoxCustom3.BorderFocusColor = Color.Red;
                textBoxCustom3.Refresh();
            });

        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

            //hace  que el panel3 se muestre en frente de los demas controles
            panel3.BringToFront();
            panel3.Dock = DockStyle.Fill;
        }

        private void textBoxCustom2__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton5_Enter(object sender, EventArgs e)
        {

        }

        private void roundButton5_MouseEnter(object sender, EventArgs e)
        {

            pictureBox4.BackColor = Color.FromArgb(220, 29, 78, 216);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void roundButton5_MouseLeave(object sender, EventArgs e)
        {
            if (roundButton5.Enabled)
            {
                pictureBox4.BackColor = Color.FromArgb(29, 78, 216);

            }
            else
            {
                pictureBox4.BackColor = Color.FromArgb(220, 29, 78, 216);
            }
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            targetPosition = pictureBox4.Left + moveAmount;

            // Iniciar la animación
            timer.Start();
        }
        private void AbrirFromMadre(object formhija)
        {
            if (contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);

            Form fh = formhija as Form;

            // Establecer TopLevel en false para agregarlo al contenedor
            fh.TopLevel = false;

            // Ajustar Dock al contenedor
            fh.Dock = DockStyle.Fill;

            // Agregar el formulario al contenedor
            this.contenedor.Controls.Add(fh);

            // Ajustar FormBorderStyle del formulario hijo a None (sin bordes)
            fh.FormBorderStyle = FormBorderStyle.None;

            // Mostrar el formulario
            fh.Show();


        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Left < targetPosition)
            {
                pictureBox4.Left += 1; // Ajusta la velocidad de la animación, moviéndose un píxel a la vez
            }
            else
            {
                // Detener la animación cuando se haya alcanzado la posición final
                timer.Stop();

                //!
                panel1.Visible = true;
                panel1.Dock = DockStyle.Fill;
                timer1.Start();
                timer1.Interval = 3000;
                
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void roundButton4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            panel1.Visible = false;
            panel1.Dock = DockStyle.None;
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
