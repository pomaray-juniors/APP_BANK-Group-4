namespace APP_BANK.Cajero
{
    partial class BusquedaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCustom1 = new APP_BANK.TextBoxCustom();
            this.roundButton3 = new APP_BANCO.RoundButton();
            this.roundButton4 = new APP_BANCO.RoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundButton3);
            this.panel1.Controls.Add(this.textBoxCustom1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.roundButton4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 548);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::APP_BANK.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(51, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(106, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 36);
            this.label4.TabIndex = 32;
            this.label4.Text = "Busque información de cuentas por número o identificación\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Inter", 18.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(103, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = "Consulta de Cuenta";
            // 
            // textBoxCustom1
            // 
            this.textBoxCustom1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCustom1.BorderColor = System.Drawing.Color.DimGray;
            this.textBoxCustom1.BorderFocusColor = System.Drawing.Color.LightGray;
            this.textBoxCustom1.BorderRadius = 6;
            this.textBoxCustom1.BorderSize = 1;
            this.textBoxCustom1.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustom1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxCustom1.Location = new System.Drawing.Point(46, 119);
            this.textBoxCustom1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxCustom1.Multiline = false;
            this.textBoxCustom1.Name = "textBoxCustom1";
            this.textBoxCustom1.Padding = new System.Windows.Forms.Padding(15, 7, 7, 7);
            this.textBoxCustom1.PasswordChar = false;
            this.textBoxCustom1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxCustom1.PlaceholderText = "Ingrese el número de cuenta o identificación";
            this.textBoxCustom1.Size = new System.Drawing.Size(714, 37);
            this.textBoxCustom1.TabIndex = 34;
            this.textBoxCustom1.Texts = "";
            this.textBoxCustom1.UnderlinedStyle = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundButton3.BorderColor = System.Drawing.Color.DimGray;
            this.roundButton3.BorderRadius = 8;
            this.roundButton3.BorderSize = 1;
            this.roundButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.roundButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.Black;
            this.roundButton3.Location = new System.Drawing.Point(769, 119);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(97, 37);
            this.roundButton3.TabIndex = 35;
            this.roundButton3.Text = "Cancelar";
            this.roundButton3.TextColor = System.Drawing.Color.Black;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton4.BorderColor = System.Drawing.Color.Silver;
            this.roundButton4.BorderRadius = 10;
            this.roundButton4.BorderSize = 1;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.ForeColor = System.Drawing.Color.White;
            this.roundButton4.Location = new System.Drawing.Point(0, 1);
            this.roundButton4.Margin = new System.Windows.Forms.Padding(30, 3, 3, 30);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(916, 213);
            this.roundButton4.TabIndex = 36;
            this.roundButton4.TextColor = System.Drawing.Color.White;
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // BusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(919, 548);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusquedaCliente";
            this.Text = "BusquedaCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private TextBoxCustom textBoxCustom1;
        private APP_BANCO.RoundButton roundButton3;
        private APP_BANCO.RoundButton roundButton4;
    }
}