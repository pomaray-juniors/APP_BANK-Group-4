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
    public partial class AperturaCuenta : Form
    {
        public AperturaCuenta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCustom1__TextChanged(object sender, EventArgs e)
        {

        }

        private void AperturaCuenta_Load(object sender, EventArgs e)
        {
            paso1.Dock = DockStyle.Fill;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton8_Click(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value = 50;
            paso1.Dock = DockStyle.None;
            Paso2.Dock = DockStyle.Fill;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            Paso2.Dock = DockStyle.None;
            paso1.Dock = DockStyle.Fill;
            guna2ProgressBar1.Value = 0;
        }

        private void Paso2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            Paso2.Dock = DockStyle.Fill;
            paso3.Dock = DockStyle.None;
            guna2ProgressBar1.Value = 50;
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Paso2.Dock = DockStyle.None;
            paso3.Dock= DockStyle.Fill;
            guna2ProgressBar1.Value = 100;
        }

        private bool isChanging = false;

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (isChanging) return;
            isChanging = true;

            if (guna2CustomRadioButton1.Checked)
            {
                guna2CustomRadioButton2.Checked = false;
                guna2CustomRadioButton3.Checked = false;
            }
            else
            {
                // Evitamos que se quede sin ninguno seleccionado
                if (!guna2CustomRadioButton2.Checked && !guna2CustomRadioButton3.Checked)
                    guna2CustomRadioButton1.Checked = true;
            }

            isChanging = false;
        }

        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (isChanging) return;
            isChanging = true;

            if (guna2CustomRadioButton2.Checked)
            {
                guna2CustomRadioButton1.Checked = false;
                guna2CustomRadioButton3.Checked = false;
            }
            else
            {
                if (!guna2CustomRadioButton1.Checked && !guna2CustomRadioButton3.Checked)
                    guna2CustomRadioButton2.Checked = true;
            }

            isChanging = false;
        }

        private void guna2CustomRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (isChanging) return;
            isChanging = true;

            if (guna2CustomRadioButton3.Checked)
            {
                guna2CustomRadioButton1.Checked = false;
                guna2CustomRadioButton2.Checked = false;
            }
            else
            {
                if (!guna2CustomRadioButton1.Checked && !guna2CustomRadioButton2.Checked)
                    guna2CustomRadioButton3.Checked = true;
            }

            isChanging = false;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            guna2CustomRadioButton1.Checked = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            guna2CustomRadioButton1.Checked = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            guna2CustomRadioButton1.Checked = true;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                roundButton5.BackColor = Color.Black;
                roundButton5.Cursor = Cursors.Hand;

            }
            else
            {
                roundButton5.Cursor = default;
                roundButton5.BackColor = Color.DimGray;
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCustom8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada si no es número
            }
        }
    }


}
