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
    public partial class GestionCliente : Form
    {
        public GestionCliente()
        {
            InitializeComponent();
        }

        private void textBoxCustom1__TextChanged(object sender, EventArgs e)
        {
           
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Intentando login con: Nombre = '{textBoxCustom1.Texts}', sajdasld'");
        }
    }
}
