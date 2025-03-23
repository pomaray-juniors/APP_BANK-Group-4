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
    public partial class InicioSC : Form
    {
        public InicioSC()
        {
            InitializeComponent();
        }

        private homeServicioCliente _formPadre;

        public InicioSC(homeServicioCliente formPadre)
        {
            InitializeComponent();
            _formPadre = formPadre; // Guarda la referencia
        }

        private void roundButton10_Click(object sender, EventArgs e)
        {
            _formPadre.MoverFormulario();
        }

        private void roundButton17_Click(object sender, EventArgs e)
        {
            _formPadre.MoverFormulario2();
        }

        private void roundButton9_Click(object sender, EventArgs e)
        {
            _formPadre.MoverFormulario3();
        }
    }
}
