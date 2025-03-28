using APP_BANK.Cajero;
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
    public partial class homeServicioCliente : Form
    {
        public homeServicioCliente()
        {
            InitializeComponent();
            AbrirFromMadreD(new InicioSC(this));

            
        }

        public void MoverFormulariom()
        {
            ButtonGC.BackColor = Color.Black;
            ButtonGC.ForeColor = Color.White;
            PictuConfig.BackColor = Color.Black;
            PictuConfig.Image = Properties.Resources.user_gear_write;

            // Restablecer estilos de los otros botones
            PictuHouse.Image = Properties.Resources.house;
            PictuHouse.BackColor = Color.White;
            buttonHouse.BackColor = Color.White;
            buttonHouse.ForeColor = Color.Black;

            PictuPlus.Image = Properties.Resources.user_plus_black;
            PictuPlus.BackColor = Color.White;
            ButtonAC.BackColor = Color.White;
            ButtonAC.ForeColor = Color.Black;

            PictuWarning.Image = Properties.Resources.warning_black;
            PictuWarning.BackColor = Color.White;
            ButtonHistorial.BackColor = Color.White;
            ButtonHistorial.ForeColor = Color.Black;

            AbrirFromMadre(new ServicioAlCliente.GestionCliente());




        }
        public void MoverFormulario2()
        {
            ButtonAC.BackColor = Color.Black;
            ButtonAC.ForeColor = Color.White;
            PictuPlus.BackColor = Color.Black;
            PictuPlus.Image = Properties.Resources.user_plus_white;

            // Restablecer estilos de los otros botones
            PictuHouse.Image = Properties.Resources.house;
            PictuHouse.BackColor = Color.White;
            buttonHouse.BackColor = Color.White;
            buttonHouse.ForeColor = Color.Black;

            PictuConfig.Image = Properties.Resources.user_gear_black;
            PictuConfig.BackColor = Color.White;
            ButtonGC.BackColor = Color.White;
            ButtonGC.ForeColor = Color.Black;

            PictuWarning.Image = Properties.Resources.warning_black;
            PictuWarning.BackColor = Color.White;
            ButtonHistorial.BackColor = Color.White;
            ButtonHistorial.ForeColor = Color.Black;


            AbrirFromMadre(new AperturaCuenta());
        }
        public void MoverFormulario3()
        {
            ButtonHistorial.BackColor = Color.Black;
            ButtonHistorial.ForeColor = Color.White;
            PictuWarning.BackColor = Color.Black;
            PictuWarning.Image = Properties.Resources.warning_white;

            // Restablecer estilos de los otros botones
            PictuHouse.Image = Properties.Resources.house;
            PictuHouse.BackColor = Color.White;
            buttonHouse.BackColor = Color.White;
            buttonHouse.ForeColor = Color.Black;

            PictuConfig.Image = Properties.Resources.user_gear_black;
            PictuConfig.BackColor = Color.White;
            ButtonGC.BackColor = Color.White;
            ButtonGC.ForeColor = Color.Black;

            PictuPlus.Image = Properties.Resources.user_plus_black;
            PictuPlus.BackColor = Color.White;
            ButtonAC.BackColor = Color.White;
            ButtonAC.ForeColor = Color.Black;
        }


        private void roundButton7_Click(object sender, EventArgs e)
        {

        }

        private void roundButton6_Click(object sender, EventArgs e)
        {

        }

        private void roundButton16_Click(object sender, EventArgs e)
        {

        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            ButtonGC.BackColor = Color.Black;
            ButtonGC.ForeColor = Color.White;
            PictuConfig.BackColor = Color.Black;
            PictuConfig.Image = Properties.Resources.user_gear_write;

            // Restablecer estilos de los otros botones
            PictuHouse.Image = Properties.Resources.house;
            PictuHouse.BackColor = Color.White;
            buttonHouse.BackColor = Color.White;
            buttonHouse.ForeColor = Color.Black;

            PictuPlus.Image = Properties.Resources.user_plus_black;
            PictuPlus.BackColor = Color.White;
            ButtonAC.BackColor = Color.White;
            ButtonAC.ForeColor = Color.Black;

            PictuWarning.Image = Properties.Resources.warning_black;
            PictuWarning.BackColor = Color.White;
            ButtonHistorial.BackColor = Color.White;
            ButtonHistorial.ForeColor = Color.Black;

            AbrirFromMadre(new ServicioAlCliente.GestionCliente());

        }


        private void roundButton3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFromMadre(object formhija)
        {
            if (contenedor_paneles.Controls.Count > 0)
                this.contenedor_paneles.Controls.RemoveAt(0);

            Form fh = formhija as Form;

            // Establecer TopLevel en false para agregarlo al contenedor
            fh.TopLevel = false;

            // Ajustar Dock al contenedor
            fh.Dock = DockStyle.Fill;

            // Agregar el formulario al contenedor
            this.contenedor_paneles.Controls.Add(fh);

            // Ajustar FormBorderStyle del formulario hijo a None (sin bordes)
            fh.FormBorderStyle = FormBorderStyle.None;

            // Mostrar el formulario
            fh.Show();


        }

        private void AbrirFromMadreD(Form formHija)
        {
            if (contenedor_paneles.Controls.Count > 0)
                this.contenedor_paneles.Controls.RemoveAt(0);

            formHija.TopLevel = false;
            formHija.Dock = DockStyle.Fill;
            formHija.FormBorderStyle = FormBorderStyle.None;

            this.contenedor_paneles.Controls.Add(formHija);
            formHija.Show();
        }

        private void roundButton6_Click_1(object sender, EventArgs e)
        {
            ButtonAC.BackColor = Color.Black;
            ButtonAC.ForeColor = Color.White;
            PictuPlus.BackColor = Color.Black;
            PictuPlus.Image = Properties.Resources.user_plus_white;

            // Restablecer estilos de los otros botones
            PictuHouse.Image = Properties.Resources.house;
            PictuHouse.BackColor = Color.White;
            buttonHouse.BackColor = Color.White;
            buttonHouse.ForeColor = Color.Black;

            PictuConfig.Image = Properties.Resources.user_gear_black;
            PictuConfig.BackColor = Color.White;
            ButtonGC.BackColor = Color.White;
            ButtonGC.ForeColor = Color.Black;

            PictuWarning.Image = Properties.Resources.warning_black;
            PictuWarning.BackColor = Color.White;
            ButtonHistorial.BackColor = Color.White;
            ButtonHistorial.ForeColor = Color.Black;


            AbrirFromMadre(new AperturaCuenta());
        }

        private void roundButton11_Click(object sender, EventArgs e)
        {
            buttonHouse.BackColor = Color.Black;
            buttonHouse.ForeColor = Color.White;
            PictuHouse.BackColor = Color.Black;
            PictuHouse.Image = Properties.Resources.house_white;

            // Restablecer estilos de los otros botones
            PictuConfig.Image = Properties.Resources.user_gear_black;
            PictuConfig.BackColor = Color.White;
            ButtonGC.BackColor = Color.White;
            ButtonGC.ForeColor = Color.Black;

            PictuPlus.Image = Properties.Resources.user_plus_black;
            PictuPlus.BackColor = Color.White;
            ButtonAC.BackColor = Color.White;
            ButtonAC.ForeColor = Color.Black;

            PictuWarning.Image = Properties.Resources.warning_black;
            PictuWarning.BackColor = Color.White;
            ButtonHistorial.BackColor = Color.White;
            ButtonHistorial.ForeColor = Color.Black;

            AbrirFromMadreD(new InicioSC(this));
        }
        private void AbrirFromMadreInicio(object formhija)
        {
            if (contenedor_f.Controls.Count > 0)
                this.contenedor_f.Controls.RemoveAt(0);

            Form fh = formhija as Form;

            // Establecer TopLevel en false para agregarlo al contenedor
            fh.TopLevel = false;

            // Ajustar Dock al contenedor
            fh.Dock = DockStyle.Fill;

            // Agregar el formulario al contenedor
            this.contenedor_f.Controls.Add(fh);

            // Ajustar FormBorderStyle del formulario hijo a None (sin bordes)
            fh.FormBorderStyle = FormBorderStyle.None;

            // Mostrar el formulario
            fh.Show();


        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            AbrirFromMadreInicio(new LoginC());
        }

        private void PictuHouse_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHistorial_Click(object sender, EventArgs e)
        {
            ButtonHistorial.BackColor = Color.Black;
            ButtonHistorial.ForeColor = Color.White;
            PictuWarning.BackColor = Color.Black;
            PictuWarning.Image = Properties.Resources.warning_white;

            // Restablecer estilos de los otros botones
            PictuHouse.Image = Properties.Resources.house;
            PictuHouse.BackColor = Color.White;
            buttonHouse.BackColor = Color.White;
            buttonHouse.ForeColor = Color.Black;

            PictuConfig.Image = Properties.Resources.user_gear_black;
            PictuConfig.BackColor = Color.White;
            ButtonGC.BackColor = Color.White;
            ButtonGC.ForeColor = Color.Black;

            PictuPlus.Image = Properties.Resources.user_plus_black;
            PictuPlus.BackColor = Color.White;
            ButtonAC.BackColor = Color.White;
            ButtonAC.ForeColor = Color.Black;
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.BackColor != Color.Black) // Solo si no está seleccionado
                {
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;

                    if (btn == buttonHouse)
                    {
                        PictuHouse.Image = Properties.Resources.house_white;
                        PictuHouse.BackColor = Color.Black;
                    }
                    else if (btn == ButtonGC)
                    {
                        PictuConfig.Image = Properties.Resources.user_gear_write;
                        PictuConfig.BackColor = Color.Black;
                    }
                    else if (btn == ButtonAC)
                    {
                        PictuPlus.Image = Properties.Resources.user_plus_white;
                        PictuPlus.BackColor = Color.Black;
                    }
                    else if (btn == ButtonHistorial)
                    {
                        PictuWarning.Image = Properties.Resources.warning_white;
                        PictuWarning.BackColor = Color.Black;
                    }
                }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Solo se vuelve al color original si no está seleccionado
                if (btn.BackColor == Color.Black && !btn.Focused)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;

                    if (btn == buttonHouse)
                    {
                        PictuHouse.Image = Properties.Resources.house_black;
                        PictuHouse.BackColor = Color.White;
                    }
                    else if (btn == ButtonGC)
                    {
                        PictuConfig.Image = Properties.Resources.user_gear_black;
                        PictuConfig.BackColor = Color.White;
                    }
                    else if (btn == ButtonAC)
                    {
                        PictuPlus.Image = Properties.Resources.user_plus_black;
                        PictuPlus.BackColor = Color.White;
                    }
                    else if (btn == ButtonHistorial)
                    {
                        PictuWarning.Image = Properties.Resources.warning_black;
                        PictuWarning.BackColor = Color.White;
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Primero deseleccionamos todos los botones
            buttonHouse.BackColor = Color.White;
            buttonHouse.ForeColor = Color.Black;
            PictuHouse.Image = Properties.Resources.house_black;
            PictuHouse.BackColor = Color.White;

            ButtonGC.BackColor = Color.White;
            ButtonGC.ForeColor = Color.Black;
            PictuConfig.Image = Properties.Resources.user_gear_black;
            PictuConfig.BackColor = Color.White;

            ButtonAC.BackColor = Color.White;
            ButtonAC.ForeColor = Color.Black;
            PictuPlus.Image = Properties.Resources.user_plus_black;
            PictuPlus.BackColor = Color.White;

            ButtonHistorial.BackColor = Color.White;
            ButtonHistorial.ForeColor = Color.Black;
            PictuWarning.Image = Properties.Resources.warning_black;
            PictuWarning.BackColor = Color.White;

            // Ahora seleccionamos el botón que fue clickeado
            if (sender == buttonHouse)
            {
                buttonHouse.BackColor = Color.Black;
                buttonHouse.ForeColor = Color.White;
                PictuHouse.Image = Properties.Resources.house_white;
                PictuHouse.BackColor = Color.Black;
            }
            else if (sender == ButtonGC)
            {
                ButtonGC.BackColor = Color.Black;
                ButtonGC.ForeColor = Color.White;
                PictuConfig.Image = Properties.Resources.user_gear_write;
                PictuConfig.BackColor = Color.Black;
            }
            else if (sender == ButtonAC)
            {
                ButtonAC.BackColor = Color.Black;
                ButtonAC.ForeColor = Color.White;
                PictuPlus.Image = Properties.Resources.user_plus_white;
                PictuPlus.BackColor = Color.Black;
            }
            else if (sender == ButtonHistorial)
            {
                ButtonHistorial.BackColor = Color.Black;
                ButtonHistorial.ForeColor = Color.White;
                PictuWarning.Image = Properties.Resources.warning_white;
                PictuWarning.BackColor = Color.Black;
            }
        }






    }
}
