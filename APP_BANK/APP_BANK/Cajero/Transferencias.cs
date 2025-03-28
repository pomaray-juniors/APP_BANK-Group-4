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
    public partial class Transferencias : Form
    {
        private ConexionDB dbConnection = new ConexionDB();


        public Transferencias()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton4_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCustom3__TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCustom3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada si no es número
            }
        }

        private void roundButton1_Click_1(object sender, EventArgs e)
        {
            string cuentaOrigenTexto = textBoxCustom1.Texts;
            string cuentaDestinoTexto = textBoxCustom2.Texts;
            string montoTexto = textBoxCustom3.Texts;
            string descripcion = textBoxCustom4.Texts;

    // Validar que los campos no estén vacíos
    if (string.IsNullOrWhiteSpace(cuentaOrigenTexto) || 
        string.IsNullOrWhiteSpace(cuentaDestinoTexto) || 
        string.IsNullOrWhiteSpace(montoTexto))
    {
        MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Convertir cuentas a int
    if (!int.TryParse(cuentaOrigenTexto, out int cuentaOrigen) || !int.TryParse(cuentaDestinoTexto, out int cuentaDestino))
    {
        MessageBox.Show("Las cuentas deben ser números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Convertir monto a decimal
    if (!decimal.TryParse(montoTexto, out decimal monto) || monto <= 0)
    {
        MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Llamar al método de transferencia
    bool transferenciaExitosa = dbConnection.RealizarTransferencia(cuentaOrigen, cuentaDestino, monto, descripcion);

    // Mostrar mensaje según el resultado
    if (transferenciaExitosa)
    {
        MessageBox.Show("Transferencia realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    else
    {
        MessageBox.Show("Error en la transferencia. Verifique los datos e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }
    }
}
