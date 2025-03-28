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

            string documento = guna2ComboBox1.Text;
            int numeroDocumento = Convert.ToInt32(textBoxCustom2.Texts);
            string nombre = textBoxCustom1.Texts;
            string apellido = textBoxCustom3.Texts;


            if (documento == null || numeroDocumento == 0 || nombre == null || apellido == null || numeroDocumento == null)
            {
                MessageBox.Show("Por favor llena todos los campos.");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

            string email = textBoxCustom7.Texts;
            string telefono = textBoxCustom6.Texts;
            string direccion = textBoxCustom5.Texts;
            string ciudad = guna2ComboBox2.Text;

            email = "";
            telefono = "";
            direccion = "";
            ciudad = "";

            Paso2.Dock = DockStyle.None;
            paso1.Dock = DockStyle.Fill;
            guna2ProgressBar1.Value = 0;
        }

        private void Paso2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            textBoxCustom8.Texts = "";


            Paso2.Dock = DockStyle.Fill;
            paso3.Dock = DockStyle.None;
            guna2ProgressBar1.Value = 50;
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string nombre = textBoxCustom1.Texts.Trim();
            string apellido = textBoxCustom3.Texts.Trim();
            string email = textBoxCustom7.Texts.Trim();
            string telefono = textBoxCustom6.Texts.Trim();
            string direccion = textBoxCustom5.Texts.Trim();
            string montoTexto = textBoxCustom8.Texts.Trim();

            // Verificar que no haya campos vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefono) ||
                string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(montoTexto))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar convertir el monto a decimal
            if (!decimal.TryParse(montoTexto.Replace(',', '.'), System.Globalization.NumberStyles.Float,
                                  System.Globalization.CultureInfo.InvariantCulture, out decimal monto))
            {
                MessageBox.Show("El monto ingresado no es válido. Usa solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determinar tipo de cuenta
            string tipoCuenta = guna2CustomRadioButton1.Checked ? "Ahorros" :
                                guna2CustomRadioButton2.Checked ? "Corriente" : "Empresarial";

            // Validar que la cédula sea un número válido
            if (!int.TryParse(textBoxCustom2.Texts.Trim(), out int cedula))
            {
                MessageBox.Show("La cédula ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generar número de cuenta aleatorio
            Random random = new Random();
            int numeroCuenta = random.Next(100000, 999999);

            // Verificar si la cédula ya existe en la base de datos antes de insertar
            ConexionDB conexion = new ConexionDB();
            if (conexion.ExisteCedula(cedula))
            {
                MessageBox.Show("El cliente ya está registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar insertar en la base de datos
            try
            {
                conexion.InsertarUsuario(cedula, nombre, apellido, email, telefono, direccion, tipoCuenta, monto, numeroCuenta);
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

            string email = textBoxCustom7.Texts;
            string telefono = textBoxCustom6.Texts;
            string direccion = textBoxCustom5.Texts;
            string ciudad = guna2ComboBox2.Text;

            if (email == null || telefono == null || direccion == null || ciudad == null)
            {
                MessageBox.Show("Por favor llena todos los campos.");
            }








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

        private void paso3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paso1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
