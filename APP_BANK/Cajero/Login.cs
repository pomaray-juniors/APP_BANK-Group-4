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
        // Variables para la animación
        private int moveAmount = 15;
        private int targetPosition;

        // Imágenes de Eye (ya existentes)
        private Image eyeOpen = APP_BANK.Properties.Resources.eye;
        private Image eyeClosed = APP_BANK.Properties.Resources.eye_closed;

        public Login()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel1.Visible = false;
        }

        // Método para iniciar la animación (unificado)
        private void StartAnimation()
        {
            targetPosition = pictureBox4.Left + moveAmount;
            timer.Start();
        }

        // Evento Click del roundButton5 que inicia la animación
        private void roundButton5_Click(object sender, EventArgs e)
        {
            // Puedes reiniciar aquí algún valor si es necesario.
            StartAnimation();
        }

        // Evento Timer para mover la imagen (unificado)
        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Left < targetPosition)
            {
                pictureBox4.Left += 1; // Mueve un píxel a la vez
            }
            else
            {
                timer.Stop();
                // Al finalizar la animación, se muestra panel1
                panel1.Visible = true;
                panel1.Dock = DockStyle.Fill;
                timer1.Interval = 3000; // Espera 3 segundos
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            panel1.Visible = false;
            panel1.Dock = DockStyle.None;
            panel3.Visible = false;
            panel2.Visible = true;
        }

        // Resto de eventos y métodos existentes
        private void roundButton1_Click(object sender, EventArgs e)
        {
            // Código para el botón 1 si lo hay...
        }

        private void textBoxCustom1__TextChanged(object sender, EventArgs e)
        {
            // Código para el TextChanged...
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Código para el PictureBox1...
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
            // Código de Paint de panel1...
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
            panel3.BringToFront();
            panel3.Dock = DockStyle.Fill;
        }

        private void textBoxCustom2__TextChanged(object sender, EventArgs e)
        {
            // Código para el TextChanged...
        }

        private void roundButton5_Enter(object sender, EventArgs e)
        {
            // Código para Enter si lo hay...
        }

        private void roundButton5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(220, 29, 78, 216);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Código para PictureBox4_Click...
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Código para Paint de panel3...
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            // Otro código para Paint de panel1...
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            // Código para roundButton4...
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Código para Paint de panel2...
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = (pictureBox6.Image == eyeOpen) ? eyeClosed : eyeOpen;
            if (pictureBox6.Image == eyeOpen)
            {
                textBoxCustom2.PasswordChar = false;
            }
            else
            {
                textBoxCustom2.PasswordChar = true;
            }
        }

        // Método para abrir formularios en el contenedor
        private void AbrirFromMadre(object formhija)
        {
            if (contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(fh);
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Show();
        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
    }
}
