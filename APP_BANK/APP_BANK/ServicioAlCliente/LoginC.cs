using APP_BANK.Cajero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_BANK.ServicioAlCliente
{
    public partial class LoginC : Form
    {
        private ConexionDB dbConnection = new ConexionDB();

        private Image eyeOpen = APP_BANK.Properties.Resources.eye;
        private Image eyeClosed = APP_BANK.Properties.Resources.eye_closed;

        private int moveAmount = 15;
        private int targetPosition;  

        public LoginC()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel1.Visible = false;
        }

     
        private void StartAnimation()
        {
            targetPosition = pictureBox4.Left + moveAmount;
            timer.Start();
        }

       
        private void roundButton5_Click(object sender, EventArgs e)
        {
            textBoxCustom3.Texts = "";
            StartAnimation();
        }

        
        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Left < targetPosition)
            {
                pictureBox4.Left += 1; 
            }
            else
            {
                timer.Stop();
                panel1.Visible = true;
                panel1.Dock = DockStyle.Fill;
                timer1.Interval = 3000; 
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

        
        private void label7_Click(object sender, EventArgs e)
        {
            textBoxCustom1.Texts = "";
            textBoxCustom2.Texts = "";
            panel3.Visible = true;
            panel3.BringToFront();
            panel3.Dock = DockStyle.Fill;
        }

        
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

        private bool EsCorreoValido(string email)
        {
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patronCorreo);
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            AbrirFromMadre(new Perfiles());
        }

        private void textBoxCustom1__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void roundButton5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(220, 29, 78, 216);
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
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

        private void roundButton2_Click(object sender, EventArgs e)
        {
            var resultado = dbConnection.VerificarUsuario(textBoxCustom1.Texts, textBoxCustom2.Texts);

            if (!string.IsNullOrEmpty(resultado.error))
            {
                MessageBox.Show("Error al verificar usuario: " + resultado.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (resultado.usuarioValido)
            {
                if (resultado.rol == "Cajero")
                {
                    MessageBox.Show("Bienvenido, Cajero.", "No puede ingresar un personal de cajero a este apartado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado.rol == "Gerente")
                {
                    AbrirFromMadre(new homeServicioCliente());
                    MessageBox.Show("Bienvenido, Bienvenido servicio al cliente.", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        
    }
}
