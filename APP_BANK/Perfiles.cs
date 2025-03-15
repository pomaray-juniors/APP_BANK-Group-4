using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_BANK
{
    public partial class Perfiles : Form
    {
        public Perfiles()
        {
            InitializeComponent();
        }

       
        private void AbrirFromMadre(object formhija)
        {
            if (contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.Show();

        }
       

        private void Perfiles_Load(object sender, EventArgs e)
        {

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            int contador = 0;

            if (contador > 1)
            {

                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else if (contador == 0)
            {
                
                contador++;
            }


            AbrirFromMadre(new Cajero.Login());
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
