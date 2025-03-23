using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace APP_BANK.Cajero
{
    public partial class homeCajero : Form
    {
        public homeCajero()
        {
            InitializeComponent();
            AbrirFromMadreD(new PanelControl(this));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {

        }

        private void roundButton6_Click(object sender, EventArgs e)
        {

        }

        private void roundButton4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void roundButton9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void roundButton7_Click(object sender, EventArgs e)
        {

        }

        private void roundButton10_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFromMadreInicio(object formhija)
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

        private void AbrirFromMadre(object formhija)
        {
            if (contenido.Controls.Count > 0)
                this.contenido.Controls.RemoveAt(0);

            Form fh = formhija as Form;

            // Establecer TopLevel en false para agregarlo al contenedor
            fh.TopLevel = false;

            // Ajustar Dock al contenedor
            fh.Dock = DockStyle.Fill;

            // Agregar el formulario al contenedor
            this.contenido.Controls.Add(fh);

            // Ajustar FormBorderStyle del formulario hijo a None (sin bordes)
            fh.FormBorderStyle = FormBorderStyle.None;

            // Mostrar el formulario
            fh.Show();


        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(0, 0, 255, 255);
            AbrirFromMadreInicio(new Cajero.Login());
        }

        private void roundButton2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(0, 0, 255, 255);

        }

        private void roundButton2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Gainsboro;
        }

        public void MoverFormulario()
        {
            button12();
        }
        public void MoverFormularioDepo()
        {
            button13();
        }
        public void MoverFormularioReti()
        {
            button14();
        }

        private void AbrirFromMadreD(Form formHija)
        {
            if (contenido.Controls.Count > 0)
                this.contenido.Controls.RemoveAt(0);

            formHija.TopLevel = false;
            formHija.Dock = DockStyle.Fill;
            formHija.FormBorderStyle = FormBorderStyle.None;

            this.contenido.Controls.Add(formHija);
            formHija.Show();
        }

        private void button12()
        {
            roundButton11.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton12.BackColor = Color.Black;
            roundButton13.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton14.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton15.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton16.BackColor = Color.FromArgb(0, 0, 255, 255);

            roundButton11.ForeColor = Color.Black;
            roundButton12.ForeColor = Color.White;
            roundButton13.ForeColor = Color.Black;
            roundButton14.ForeColor = Color.Black;
            roundButton15.ForeColor = Color.Black;
            roundButton16.ForeColor = Color.Black;

            AbrirFromMadre(new Cajero.Transferencias());

            pictureBox6.Image = Properties.Resources.house_black;
            pictureBox6.BackColor = Color.White;

            pictureBox7.Image = Properties.Resources.arrows_left_right_bold;
            pictureBox7.BackColor = Color.Black;

            pictureBox8.Image = Properties.Resources.arrow_down;
            pictureBox8.BackColor = Color.White;

            pictureBox9.Image = Properties.Resources.arrow_up;
            pictureBox9.BackColor = Color.White;

            pictureBox10.Image = Properties.Resources.magnifying_glass;
            pictureBox10.BackColor = Color.White;

            pictureBox11.Image = Properties.Resources.clock;
            pictureBox11.BackColor = Color.White;
        
        }

        private void roundButton12_Click(object sender, EventArgs e)
        {
            roundButton11.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton12.BackColor = Color.Black;
            roundButton13.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton14.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton15.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton16.BackColor = Color.FromArgb(0, 0, 255, 255);

            roundButton11.ForeColor = Color.Black;
            roundButton12.ForeColor = Color.White;
            roundButton13.ForeColor = Color.Black;
            roundButton14.ForeColor = Color.Black;
            roundButton15.ForeColor = Color.Black;
            roundButton16.ForeColor = Color.Black;

            pictureBox6.Image = Properties.Resources.house_black;
            pictureBox6.BackColor = Color.White;

            pictureBox7.Image = Properties.Resources.arrows_left_right_bold;
            pictureBox7.BackColor = Color.Black;

            pictureBox8.Image = Properties.Resources.arrow_down;
            pictureBox8.BackColor = Color.White;

            pictureBox9.Image = Properties.Resources.arrow_up;
            pictureBox9.BackColor = Color.White;

            pictureBox10.Image = Properties.Resources.magnifying_glass;
            pictureBox10.BackColor = Color.White;

            pictureBox11.Image = Properties.Resources.clock;
            pictureBox11.BackColor = Color.White;

            AbrirFromMadre(new Cajero.Transferencias());
        }




        private void roundButton11_Click(object sender, EventArgs e)
        {
            roundButton11.BackColor = Color.Black;
            roundButton12.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton13.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton14.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton15.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton16.BackColor = Color.FromArgb(0, 0, 255, 255);

            roundButton11.ForeColor = Color.White;
            roundButton12.ForeColor = Color.Black;
            roundButton13.ForeColor = Color.Black;
            roundButton14.ForeColor = Color.Black;
            roundButton15.ForeColor = Color.Black;
            roundButton16.ForeColor = Color.Black;

            pictureBox6.Image = Properties.Resources.house_white;
            pictureBox6.BackColor = Color.Black;

            pictureBox7.Image = Properties.Resources.arrows_left_right_black;
            pictureBox7.BackColor = Color.White;

            pictureBox8.Image = Properties.Resources.arrow_down;
            pictureBox8.BackColor = Color.White;

            pictureBox9.Image = Properties.Resources.arrow_up;
            pictureBox9.BackColor = Color.White;

            pictureBox10.Image = Properties.Resources.magnifying_glass;
            pictureBox10.BackColor = Color.White;

            pictureBox11.Image = Properties.Resources.clock;
            pictureBox11.BackColor = Color.White;

            AbrirFromMadreD(new PanelControl(this));
        }


        private void button13()
        {
            roundButton11.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton12.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton13.BackColor = Color.Black;
            roundButton14.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton15.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton16.BackColor = Color.FromArgb(0, 0, 255, 255);

            roundButton11.ForeColor = Color.Black;
            roundButton12.ForeColor = Color.Black;
            roundButton13.ForeColor = Color.White;
            roundButton14.ForeColor = Color.Black;
            roundButton15.ForeColor = Color.Black;
            roundButton16.ForeColor = Color.Black;

            AbrirFromMadre(new Cajero.Deposito());

            pictureBox6.Image = Properties.Resources.house_black;
            pictureBox6.BackColor = Color.White;

            pictureBox7.Image = Properties.Resources.arrows_left_right_black;
            pictureBox7.BackColor = Color.White;

            pictureBox8.Image = Properties.Resources.arrow_down_white;
            pictureBox8.BackColor = Color.Black;

            pictureBox9.Image = Properties.Resources.arrow_up;
            pictureBox9.BackColor = Color.White;

            pictureBox10.Image = Properties.Resources.magnifying_glass;
            pictureBox10.BackColor = Color.White;

            pictureBox11.Image = Properties.Resources.clock;
            pictureBox11.BackColor = Color.White;
        }

        private void roundButton13_Click_1(object sender, EventArgs e)
        {
            roundButton11.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton12.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton13.BackColor = Color.Black;
            roundButton14.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton15.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton16.BackColor = Color.FromArgb(0, 0, 255, 255);

            roundButton11.ForeColor = Color.Black;
            roundButton12.ForeColor = Color.Black;
            roundButton13.ForeColor = Color.White;
            roundButton14.ForeColor = Color.Black;
            roundButton15.ForeColor = Color.Black;
            roundButton16.ForeColor = Color.Black;

            pictureBox6.Image = Properties.Resources.house_black;
            pictureBox6.BackColor = Color.White;

            pictureBox7.Image = Properties.Resources.arrows_left_right_black;
            pictureBox7.BackColor = Color.White;

            pictureBox8.Image = Properties.Resources.arrow_down_white;
            pictureBox8.BackColor = Color.Black;

            pictureBox9.Image = Properties.Resources.arrow_up;
            pictureBox9.BackColor = Color.White;

            pictureBox10.Image = Properties.Resources.magnifying_glass;
            pictureBox10.BackColor = Color.White;

            pictureBox11.Image = Properties.Resources.clock;
            pictureBox11.BackColor = Color.White;

            AbrirFromMadre(new Cajero.Deposito());
        }


        private void button14()
        {

            roundButton11.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton12.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton13.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton14.BackColor = Color.Black;
            roundButton15.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton16.BackColor = Color.FromArgb(0, 0, 255, 255);

            roundButton11.ForeColor = Color.Black;
            roundButton12.ForeColor = Color.Black;
            roundButton13.ForeColor = Color.Black;
            roundButton14.ForeColor = Color.White;
            roundButton15.ForeColor = Color.Black;
            roundButton16.ForeColor = Color.Black;

            AbrirFromMadre(new Cajero.Retiros());

            pictureBox6.Image = Properties.Resources.house_black;
            pictureBox6.BackColor = Color.White;

            pictureBox7.Image = Properties.Resources.arrows_left_right_black;
            pictureBox7.BackColor = Color.White;

            pictureBox8.Image = Properties.Resources.arrow_down;
            pictureBox8.BackColor = Color.White;

            pictureBox9.Image = Properties.Resources.arrow_up_white;
            pictureBox9.BackColor = Color.Black;

            pictureBox10.Image = Properties.Resources.magnifying_glass;
            pictureBox10.BackColor = Color.White;

            pictureBox11.Image = Properties.Resources.clock;
            pictureBox11.BackColor = Color.White;
        }

        private void roundButton14_Click_1(object sender, EventArgs e)
        {
            roundButton11.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton12.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton13.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton14.BackColor = Color.Black;
            roundButton15.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton16.BackColor = Color.FromArgb(0, 0, 255, 255);

            roundButton11.ForeColor = Color.Black;
            roundButton12.ForeColor = Color.Black;
            roundButton13.ForeColor = Color.Black;
            roundButton14.ForeColor = Color.White;
            roundButton15.ForeColor = Color.Black;
            roundButton16.ForeColor = Color.Black;

            pictureBox6.Image = Properties.Resources.house_black;
            pictureBox6.BackColor = Color.White;

            pictureBox7.Image = Properties.Resources.arrows_left_right_black;
            pictureBox7.BackColor = Color.White;

            pictureBox8.Image = Properties.Resources.arrow_down;
            pictureBox8.BackColor = Color.White;

            pictureBox9.Image = Properties.Resources.arrow_up_white;
            pictureBox9.BackColor = Color.Black;

            pictureBox10.Image = Properties.Resources.magnifying_glass;
            pictureBox10.BackColor = Color.White;

            pictureBox11.Image = Properties.Resources.clock;
            pictureBox11.BackColor = Color.White;

            AbrirFromMadre(new Cajero.Retiros());
        }


        private void roundButton15_Click(object sender, EventArgs e)
        {
            roundButton11.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton12.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton13.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton14.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton15.BackColor = Color.Black;
            roundButton16.BackColor = Color.FromArgb(0, 0, 255, 255);

            roundButton11.ForeColor = Color.Black;
            roundButton12.ForeColor = Color.Black;
            roundButton13.ForeColor = Color.Black;
            roundButton14.ForeColor = Color.Black;
            roundButton15.ForeColor = Color.White;
            roundButton16.ForeColor = Color.Black;

            pictureBox6.Image = Properties.Resources.house_black;
            pictureBox6.BackColor = Color.White;

            pictureBox7.Image = Properties.Resources.arrows_left_right_black;
            pictureBox7.BackColor = Color.White;

            pictureBox8.Image = Properties.Resources.arrow_down;
            pictureBox8.BackColor = Color.White;

            pictureBox9.Image = Properties.Resources.arrow_up;
            pictureBox9.BackColor = Color.White;

            pictureBox10.Image = Properties.Resources.magnifying_glass_white;
            pictureBox10.BackColor = Color.Black;

            pictureBox11.Image = Properties.Resources.clock;
            pictureBox11.BackColor = Color.White;

            AbrirFromMadre(new Cajero.BusquedaCliente());
        }


        private void roundButton16_Click_1(object sender, EventArgs e)
        {
            roundButton11.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton12.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton13.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton14.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton15.BackColor = Color.FromArgb(0, 0, 255, 255);
            roundButton16.BackColor = Color.Black;

            roundButton11.ForeColor = Color.Black;
            roundButton12.ForeColor = Color.Black;
            roundButton13.ForeColor = Color.Black;
            roundButton14.ForeColor = Color.Black;
            roundButton15.ForeColor = Color.Black;
            roundButton16.ForeColor = Color.White;

            pictureBox6.Image = Properties.Resources.house_black;
            pictureBox6.BackColor = Color.White;

            pictureBox7.Image = Properties.Resources.arrows_left_right_black;
            pictureBox7.BackColor = Color.White;

            pictureBox8.Image = Properties.Resources.arrow_down;
            pictureBox8.BackColor = Color.White;

            pictureBox9.Image = Properties.Resources.arrow_up;
            pictureBox9.BackColor = Color.White;

            pictureBox10.Image = Properties.Resources.magnifying_glass;
            pictureBox10.BackColor = Color.White;

            pictureBox11.Image = Properties.Resources.clock_white;
            pictureBox11.BackColor = Color.Black;
        }




        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeCajero_Load(object sender, EventArgs e)
        {
        }

        private void roundButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.White; // Cambia el texto a blanco
        }

        private void roundButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Color.Black)
            { btn.ForeColor = Color.White;
                
            }
            else
            { btn.ForeColor = Color.Black; }
        }

        private void roundButton8_Click(object sender, EventArgs e)
        {
            
            AbrirFromMadre(new Cajero.Transferencias());
        }

        private void roundButton8_Click_1(object sender, EventArgs e)
        {
            AbrirFromMadre(new Cajero.Transferencias());
        }

        private void roundButton9_Click_1(object sender, EventArgs e)
        {
            AbrirFromMadre(new Cajero.Deposito());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        // Botón 1: Inicio - Asociado a pictureBox6
        private void roundButton11_MouseEnter(object sender, EventArgs e)
        {
            if (roundButton11.BackColor != Color.Black)
            {
                roundButton11.ForeColor = Color.White;
                pictureBox6.Image = Properties.Resources.house_white;
                pictureBox6.BackColor = Color.Black;
            }
        }

        private void roundButton11_MouseLeave(object sender, EventArgs e)
        {
            if (roundButton11.BackColor != Color.Black)
            {
                roundButton11.ForeColor = Color.Black;
                pictureBox6.Image = Properties.Resources.house_black;
                pictureBox6.BackColor = Color.White;
            }
        }

        // Botón 2: Transferencias - Asociado a pictureBox7
        private void roundButton12_MouseEnter(object sender, EventArgs e)
        {
            if (roundButton12.BackColor != Color.Black)
            {
                roundButton12.ForeColor = Color.White;
                // Usamos la imagen de hover (en este ejemplo "bold") para mostrar la versión blanca
                pictureBox7.Image = Properties.Resources.arrows_left_right_bold;
                pictureBox7.BackColor = Color.Black;
            }
        }

        private void roundButton12_MouseLeave(object sender, EventArgs e)
        {
            if (roundButton12.BackColor != Color.Black)
            {
                roundButton12.ForeColor = Color.Black;
                pictureBox7.Image = Properties.Resources.arrows_left_right_black;
                pictureBox7.BackColor = Color.White;
            }
        }

        // Botón 3: Depósito - Asociado a pictureBox8
        private void roundButton13_MouseEnter(object sender, EventArgs e)
        {
            if (roundButton13.BackColor != Color.Black)
            {
                roundButton13.ForeColor = Color.White;
                pictureBox8.Image = Properties.Resources.arrow_down_white;
                pictureBox8.BackColor = Color.Black;
            }
        }

        private void roundButton13_MouseLeave(object sender, EventArgs e)
        {
            if (roundButton13.BackColor != Color.Black)
            {
                roundButton13.ForeColor = Color.Black;
                pictureBox8.Image = Properties.Resources.arrow_down;
                pictureBox8.BackColor = Color.White;
            }
        }

        // Botón 4: Retiro - Asociado a pictureBox9
        private void roundButton14_MouseEnter(object sender, EventArgs e)
        {
            if (roundButton14.BackColor != Color.Black)
            {
                roundButton14.ForeColor = Color.White;
                pictureBox9.Image = Properties.Resources.arrow_up_white;
                pictureBox9.BackColor = Color.Black;
            }
        }

        private void roundButton14_MouseLeave(object sender, EventArgs e)
        {
            if (roundButton14.BackColor != Color.Black)
            {
                roundButton14.ForeColor = Color.Black;
                pictureBox9.Image = Properties.Resources.arrow_up;
                pictureBox9.BackColor = Color.White;
            }
        }

        // Botón 5: Consulta Cuenta - Asociado a pictureBox10
        private void roundButton15_MouseEnter(object sender, EventArgs e)
        {
            if (roundButton15.BackColor != Color.Black)
            {
                roundButton15.ForeColor = Color.White;
                pictureBox10.Image = Properties.Resources.magnifying_glass_white;
                pictureBox10.BackColor = Color.Black;
            }
        }

        private void roundButton15_MouseLeave(object sender, EventArgs e)
        {
            if (roundButton15.BackColor != Color.Black)
            {
                roundButton15.ForeColor = Color.Black;
                pictureBox10.Image = Properties.Resources.magnifying_glass;
                pictureBox10.BackColor = Color.White;
            }
        }

        // Botón 6: Historial - Asociado a pictureBox11
        private void roundButton16_MouseEnter(object sender, EventArgs e)
        {
            if (roundButton16.BackColor != Color.Black)
            {
                roundButton16.ForeColor = Color.White;
                pictureBox11.Image = Properties.Resources.clock_white;
                pictureBox11.BackColor = Color.Black;
            }
        }

        private void roundButton16_MouseLeave(object sender, EventArgs e)
        {
            if (roundButton16.BackColor != Color.Black)
            {
                roundButton16.ForeColor = Color.Black;
                // En este caso, la imagen por defecto es clock, según tu código en el Click
                pictureBox11.Image = Properties.Resources.clock;
                pictureBox11.BackColor = Color.White;
            }
        }
    }
}
