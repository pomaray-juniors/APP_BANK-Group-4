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
