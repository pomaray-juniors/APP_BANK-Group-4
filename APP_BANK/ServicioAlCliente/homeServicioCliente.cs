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
            AbrirFromMadre(new InicioSC());
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
        private void roundButton6_Click_1(object sender, EventArgs e)
        {
            AbrirFromMadre(new AperturaCuenta());
        }

        private void roundButton11_Click(object sender, EventArgs e)
        {
            AbrirFromMadre(new InicioSC());
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
    }
}
