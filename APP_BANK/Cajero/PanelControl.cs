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
    public partial class PanelControl : Form
    {
        public PanelControl()
        {
            InitializeComponent();
        }

        private homeCajero _formPadre;

        public PanelControl(homeCajero formPadre)
        {
            InitializeComponent();
            _formPadre = formPadre; // Guarda la referencia
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

        private void roundButton9_Click(object sender, EventArgs e)
        {
            _formPadre.MoverFormularioDepo();
        }

        private void roundButton8_Click(object sender, EventArgs e)
        {
            _formPadre.MoverFormulario();

        }

        private void roundButton10_Click(object sender, EventArgs e)
        {
            _formPadre.MoverFormularioReti();
        }
    }
}
