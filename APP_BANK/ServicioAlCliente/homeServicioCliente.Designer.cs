namespace APP_BANK.ServicioAlCliente
{
    partial class homeServicioCliente
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
            this.contenedor_f = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.PictuWarning = new System.Windows.Forms.PictureBox();
            this.ButtonHistorial = new APP_BANCO.RoundButton();
            this.PictuPlus = new System.Windows.Forms.PictureBox();
            this.ButtonAC = new APP_BANCO.RoundButton();
            this.PictuConfig = new System.Windows.Forms.PictureBox();
            this.contenedor_paneles = new System.Windows.Forms.Panel();
            this.PictuHouse = new System.Windows.Forms.PictureBox();
            this.buttonHouse = new APP_BANCO.RoundButton();
            this.ButtonGC = new APP_BANCO.RoundButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.roundButton2 = new APP_BANCO.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundButton1 = new APP_BANCO.RoundButton();
            this.roundButton3 = new APP_BANCO.RoundButton();
            this.contenedor_f.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictuWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictuPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictuConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictuHouse)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor_f
            // 
            this.contenedor_f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.contenedor_f.Controls.Add(this.contenedor);
            this.contenedor_f.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor_f.Location = new System.Drawing.Point(0, 0);
            this.contenedor_f.Name = "contenedor_f";
            this.contenedor_f.Size = new System.Drawing.Size(1251, 711);
            this.contenedor_f.TabIndex = 0;
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.contenedor.Controls.Add(this.PictuWarning);
            this.contenedor.Controls.Add(this.ButtonHistorial);
            this.contenedor.Controls.Add(this.PictuPlus);
            this.contenedor.Controls.Add(this.ButtonAC);
            this.contenedor.Controls.Add(this.PictuConfig);
            this.contenedor.Controls.Add(this.contenedor_paneles);
            this.contenedor.Controls.Add(this.PictuHouse);
            this.contenedor.Controls.Add(this.buttonHouse);
            this.contenedor.Controls.Add(this.ButtonGC);
            this.contenedor.Controls.Add(this.panel3);
            this.contenedor.Controls.Add(this.roundButton3);
            this.contenedor.Location = new System.Drawing.Point(3, 3);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1245, 696);
            this.contenedor.TabIndex = 0;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // PictuWarning
            // 
            this.PictuWarning.BackColor = System.Drawing.Color.Transparent;
            this.PictuWarning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictuWarning.Image = global::APP_BANK.Properties.Resources.warning_black;
            this.PictuWarning.Location = new System.Drawing.Point(79, 253);
            this.PictuWarning.Name = "PictuWarning";
            this.PictuWarning.Size = new System.Drawing.Size(26, 26);
            this.PictuWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictuWarning.TabIndex = 77;
            this.PictuWarning.TabStop = false;
            // 
            // ButtonHistorial
            // 
            this.ButtonHistorial.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHistorial.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonHistorial.BorderColor = System.Drawing.Color.Gray;
            this.ButtonHistorial.BorderRadius = 10;
            this.ButtonHistorial.BorderSize = 1;
            this.ButtonHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHistorial.FlatAppearance.BorderSize = 0;
            this.ButtonHistorial.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.ButtonHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ButtonHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ButtonHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHistorial.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHistorial.ForeColor = System.Drawing.Color.Black;
            this.ButtonHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHistorial.Location = new System.Drawing.Point(63, 245);
            this.ButtonHistorial.Name = "ButtonHistorial";
            this.ButtonHistorial.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.ButtonHistorial.Size = new System.Drawing.Size(210, 40);
            this.ButtonHistorial.TabIndex = 76;
            this.ButtonHistorial.Text = "Historial";
            this.ButtonHistorial.TextColor = System.Drawing.Color.Black;
            this.ButtonHistorial.UseVisualStyleBackColor = false;
            this.ButtonHistorial.Click += new System.EventHandler(this.ButtonHistorial_Click);
            this.ButtonHistorial.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ButtonHistorial.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // PictuPlus
            // 
            this.PictuPlus.BackColor = System.Drawing.Color.Transparent;
            this.PictuPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictuPlus.Image = global::APP_BANK.Properties.Resources.user_plus_black;
            this.PictuPlus.Location = new System.Drawing.Point(79, 207);
            this.PictuPlus.Name = "PictuPlus";
            this.PictuPlus.Size = new System.Drawing.Size(26, 26);
            this.PictuPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictuPlus.TabIndex = 75;
            this.PictuPlus.TabStop = false;
            this.PictuPlus.Click += new System.EventHandler(this.roundButton6_Click_1);
            // 
            // ButtonAC
            // 
            this.ButtonAC.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAC.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonAC.BorderColor = System.Drawing.Color.Gray;
            this.ButtonAC.BorderRadius = 10;
            this.ButtonAC.BorderSize = 1;
            this.ButtonAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAC.FlatAppearance.BorderSize = 0;
            this.ButtonAC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.ButtonAC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ButtonAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ButtonAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAC.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAC.ForeColor = System.Drawing.Color.Black;
            this.ButtonAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAC.Location = new System.Drawing.Point(63, 199);
            this.ButtonAC.Name = "ButtonAC";
            this.ButtonAC.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.ButtonAC.Size = new System.Drawing.Size(210, 40);
            this.ButtonAC.TabIndex = 74;
            this.ButtonAC.Text = "Apertura de la cuenta";
            this.ButtonAC.TextColor = System.Drawing.Color.Black;
            this.ButtonAC.UseVisualStyleBackColor = false;
            this.ButtonAC.Click += new System.EventHandler(this.roundButton6_Click_1);
            this.ButtonAC.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ButtonAC.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // PictuConfig
            // 
            this.PictuConfig.BackColor = System.Drawing.Color.Transparent;
            this.PictuConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictuConfig.Image = global::APP_BANK.Properties.Resources.user_gear_black;
            this.PictuConfig.Location = new System.Drawing.Point(79, 159);
            this.PictuConfig.Name = "PictuConfig";
            this.PictuConfig.Size = new System.Drawing.Size(26, 26);
            this.PictuConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictuConfig.TabIndex = 73;
            this.PictuConfig.TabStop = false;
            this.PictuConfig.Click += new System.EventHandler(this.roundButton5_Click);
            // 
            // contenedor_paneles
            // 
            this.contenedor_paneles.Location = new System.Drawing.Point(301, 98);
            this.contenedor_paneles.Name = "contenedor_paneles";
            this.contenedor_paneles.Size = new System.Drawing.Size(922, 571);
            this.contenedor_paneles.TabIndex = 56;
            // 
            // PictuHouse
            // 
            this.PictuHouse.BackColor = System.Drawing.Color.Black;
            this.PictuHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictuHouse.Image = global::APP_BANK.Properties.Resources.house_white;
            this.PictuHouse.Location = new System.Drawing.Point(77, 113);
            this.PictuHouse.Name = "PictuHouse";
            this.PictuHouse.Size = new System.Drawing.Size(26, 26);
            this.PictuHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictuHouse.TabIndex = 65;
            this.PictuHouse.TabStop = false;
            this.PictuHouse.Click += new System.EventHandler(this.roundButton11_Click);
            // 
            // buttonHouse
            // 
            this.buttonHouse.BackColor = System.Drawing.Color.Black;
            this.buttonHouse.BackgroundColor = System.Drawing.Color.Black;
            this.buttonHouse.BorderColor = System.Drawing.Color.Gray;
            this.buttonHouse.BorderRadius = 10;
            this.buttonHouse.BorderSize = 1;
            this.buttonHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHouse.FlatAppearance.BorderSize = 0;
            this.buttonHouse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttonHouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonHouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHouse.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHouse.ForeColor = System.Drawing.Color.White;
            this.buttonHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHouse.Location = new System.Drawing.Point(63, 105);
            this.buttonHouse.Name = "buttonHouse";
            this.buttonHouse.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.buttonHouse.Size = new System.Drawing.Size(210, 40);
            this.buttonHouse.TabIndex = 56;
            this.buttonHouse.Text = "Inicio";
            this.buttonHouse.TextColor = System.Drawing.Color.White;
            this.buttonHouse.UseVisualStyleBackColor = false;
            this.buttonHouse.Click += new System.EventHandler(this.roundButton11_Click);
            this.buttonHouse.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonHouse.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ButtonGC
            // 
            this.ButtonGC.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGC.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonGC.BorderColor = System.Drawing.Color.Gray;
            this.ButtonGC.BorderRadius = 10;
            this.ButtonGC.BorderSize = 1;
            this.ButtonGC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGC.FlatAppearance.BorderSize = 0;
            this.ButtonGC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.ButtonGC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ButtonGC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ButtonGC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGC.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGC.ForeColor = System.Drawing.Color.Black;
            this.ButtonGC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGC.Location = new System.Drawing.Point(63, 151);
            this.ButtonGC.Name = "ButtonGC";
            this.ButtonGC.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.ButtonGC.Size = new System.Drawing.Size(210, 40);
            this.ButtonGC.TabIndex = 69;
            this.ButtonGC.Text = "Gestion de Clientes";
            this.ButtonGC.TextColor = System.Drawing.Color.Black;
            this.ButtonGC.UseVisualStyleBackColor = false;
            this.ButtonGC.Click += new System.EventHandler(this.roundButton5_Click);
            this.ButtonGC.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ButtonGC.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.roundButton2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.roundButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1245, 65);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::APP_BANK.Properties.Resources.sign_out;
            this.pictureBox2.Location = new System.Drawing.Point(1146, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Transparent;
            this.roundButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.roundButton2.BorderRadius = 8;
            this.roundButton2.BorderSize = 1;
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roundButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.Black;
            this.roundButton2.Location = new System.Drawing.Point(1139, 11);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.roundButton2.Size = new System.Drawing.Size(97, 40);
            this.roundButton2.TabIndex = 4;
            this.roundButton2.Text = "Salir";
            this.roundButton2.TextColor = System.Drawing.Color.Black;
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema Bancario - Servicio al Cliente\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pictureBox1.Image = global::APP_BANK.Properties.Resources.arrows_left_right_bold;
            this.pictureBox1.Location = new System.Drawing.Point(71, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.roundButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.roundButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton1.BorderRadius = 22;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(63, 8);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(49, 45);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton3.BorderColor = System.Drawing.Color.Silver;
            this.roundButton3.BorderRadius = 8;
            this.roundButton3.BorderSize = 1;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(50, 98);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(232, 200);
            this.roundButton3.TabIndex = 55;
            this.roundButton3.TextColor = System.Drawing.Color.White;
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // homeServicioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 711);
            this.Controls.Add(this.contenedor_f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "homeServicioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homeServicioCliente";
            this.contenedor_f.ResumeLayout(false);
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictuWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictuPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictuConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictuHouse)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor_f;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private APP_BANCO.RoundButton roundButton1;
        private APP_BANCO.RoundButton roundButton3;
        private APP_BANCO.RoundButton ButtonGC;
        private APP_BANCO.RoundButton buttonHouse;
        private System.Windows.Forms.PictureBox PictuHouse;
        private System.Windows.Forms.Panel contenedor_paneles;
        private System.Windows.Forms.PictureBox PictuWarning;
        private APP_BANCO.RoundButton ButtonHistorial;
        private System.Windows.Forms.PictureBox PictuPlus;
        private APP_BANCO.RoundButton ButtonAC;
        private System.Windows.Forms.PictureBox PictuConfig;
        private System.Windows.Forms.PictureBox pictureBox2;
        private APP_BANCO.RoundButton roundButton2;
    }
}