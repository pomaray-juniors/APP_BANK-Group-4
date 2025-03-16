namespace APP_BANK.Cajero
{
    partial class PanelControl
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
            this.contenido = new System.Windows.Forms.Panel();
            this.contenedor_paneles = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.roundButton10 = new APP_BANCO.RoundButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.roundButton9 = new APP_BANCO.RoundButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.roundButton8 = new APP_BANCO.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.roundButton5 = new APP_BANCO.RoundButton();
            this.roundButton6 = new APP_BANCO.RoundButton();
            this.roundButton7 = new APP_BANCO.RoundButton();
            this.label15 = new System.Windows.Forms.Label();
            this.roundButton4 = new APP_BANCO.RoundButton();
            this.contenido.SuspendLayout();
            this.contenedor_paneles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // contenido
            // 
            this.contenido.Controls.Add(this.contenedor_paneles);
            this.contenido.Location = new System.Drawing.Point(1, 4);
            this.contenido.Name = "contenido";
            this.contenido.Size = new System.Drawing.Size(919, 540);
            this.contenido.TabIndex = 57;
            // 
            // contenedor_paneles
            // 
            this.contenedor_paneles.Controls.Add(this.label2);
            this.contenedor_paneles.Controls.Add(this.roundButton10);
            this.contenedor_paneles.Controls.Add(this.label5);
            this.contenedor_paneles.Controls.Add(this.pictureBox5);
            this.contenedor_paneles.Controls.Add(this.roundButton9);
            this.contenedor_paneles.Controls.Add(this.label4);
            this.contenedor_paneles.Controls.Add(this.pictureBox4);
            this.contenedor_paneles.Controls.Add(this.pictureBox3);
            this.contenedor_paneles.Controls.Add(this.roundButton8);
            this.contenedor_paneles.Controls.Add(this.label3);
            this.contenedor_paneles.Controls.Add(this.roundButton5);
            this.contenedor_paneles.Controls.Add(this.roundButton6);
            this.contenedor_paneles.Controls.Add(this.roundButton7);
            this.contenedor_paneles.Controls.Add(this.label15);
            this.contenedor_paneles.Controls.Add(this.roundButton4);
            this.contenedor_paneles.Location = new System.Drawing.Point(3, 3);
            this.contenedor_paneles.Name = "contenedor_paneles";
            this.contenedor_paneles.Size = new System.Drawing.Size(919, 474);
            this.contenedor_paneles.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Panel de Control";
            // 
            // roundButton10
            // 
            this.roundButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.roundButton10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.roundButton10.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton10.BorderRadius = 6;
            this.roundButton10.BorderSize = 0;
            this.roundButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton10.FlatAppearance.BorderSize = 0;
            this.roundButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton10.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton10.ForeColor = System.Drawing.Color.White;
            this.roundButton10.Location = new System.Drawing.Point(803, 142);
            this.roundButton10.Name = "roundButton10";
            this.roundButton10.Size = new System.Drawing.Size(77, 35);
            this.roundButton10.TabIndex = 42;
            this.roundButton10.Text = "Realizar";
            this.roundButton10.TextColor = System.Drawing.Color.White;
            this.roundButton10.UseVisualStyleBackColor = false;
            this.roundButton10.Click += new System.EventHandler(this.roundButton10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.label5.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(647, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Retiros";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.pictureBox5.Image = global::APP_BANK.Properties.Resources.arrow_up_color;
            this.pictureBox5.Location = new System.Drawing.Point(650, 143);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // roundButton9
            // 
            this.roundButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(157)))), ((int)(((byte)(72)))));
            this.roundButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(157)))), ((int)(((byte)(72)))));
            this.roundButton9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton9.BorderRadius = 6;
            this.roundButton9.BorderSize = 0;
            this.roundButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton9.FlatAppearance.BorderSize = 0;
            this.roundButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton9.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton9.ForeColor = System.Drawing.Color.White;
            this.roundButton9.Location = new System.Drawing.Point(512, 146);
            this.roundButton9.Name = "roundButton9";
            this.roundButton9.Size = new System.Drawing.Size(77, 35);
            this.roundButton9.TabIndex = 39;
            this.roundButton9.Text = "Realizar";
            this.roundButton9.TextColor = System.Drawing.Color.White;
            this.roundButton9.UseVisualStyleBackColor = false;
            this.roundButton9.Click += new System.EventHandler(this.roundButton9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.label4.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(352, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Depósitos";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.pictureBox4.Image = global::APP_BANK.Properties.Resources.arrow_down_color;
            this.pictureBox4.Location = new System.Drawing.Point(355, 148);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.pictureBox3.Image = global::APP_BANK.Properties.Resources.arrows_left_right;
            this.pictureBox3.Location = new System.Drawing.Point(52, 147);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // roundButton8
            // 
            this.roundButton8.BackColor = System.Drawing.Color.Black;
            this.roundButton8.BackgroundColor = System.Drawing.Color.Black;
            this.roundButton8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton8.BorderRadius = 6;
            this.roundButton8.BorderSize = 0;
            this.roundButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton8.FlatAppearance.BorderSize = 0;
            this.roundButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton8.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton8.ForeColor = System.Drawing.Color.White;
            this.roundButton8.Location = new System.Drawing.Point(208, 146);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(77, 35);
            this.roundButton8.TabIndex = 36;
            this.roundButton8.Text = "Realizar";
            this.roundButton8.TextColor = System.Drawing.Color.White;
            this.roundButton8.UseVisualStyleBackColor = false;
            this.roundButton8.Click += new System.EventHandler(this.roundButton8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.label3.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(49, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Transferencias";
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.roundButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.roundButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundButton5.BorderRadius = 10;
            this.roundButton5.BorderSize = 1;
            this.roundButton5.FlatAppearance.BorderSize = 0;
            this.roundButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.roundButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.roundButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton5.ForeColor = System.Drawing.Color.White;
            this.roundButton5.Location = new System.Drawing.Point(30, 98);
            this.roundButton5.Margin = new System.Windows.Forms.Padding(30, 3, 3, 30);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(276, 122);
            this.roundButton5.TabIndex = 3;
            this.roundButton5.TextColor = System.Drawing.Color.White;
            this.roundButton5.UseVisualStyleBackColor = false;
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.roundButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.roundButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundButton6.BorderRadius = 10;
            this.roundButton6.BorderSize = 1;
            this.roundButton6.FlatAppearance.BorderSize = 0;
            this.roundButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.roundButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.ForeColor = System.Drawing.Color.White;
            this.roundButton6.Location = new System.Drawing.Point(327, 98);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(276, 122);
            this.roundButton6.TabIndex = 4;
            this.roundButton6.TextColor = System.Drawing.Color.White;
            this.roundButton6.UseVisualStyleBackColor = false;
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.roundButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.roundButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundButton7.BorderRadius = 10;
            this.roundButton7.BorderSize = 1;
            this.roundButton7.FlatAppearance.BorderSize = 0;
            this.roundButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.roundButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.roundButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton7.ForeColor = System.Drawing.Color.White;
            this.roundButton7.Location = new System.Drawing.Point(619, 98);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(276, 122);
            this.roundButton7.TabIndex = 5;
            this.roundButton7.TextColor = System.Drawing.Color.White;
            this.roundButton7.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Inter Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label15.Location = new System.Drawing.Point(44, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(308, 22);
            this.label15.TabIndex = 34;
            this.label15.Text = "Bienvenido al sistema de cajero bancario";
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
            this.roundButton4.Location = new System.Drawing.Point(2, 1);
            this.roundButton4.Margin = new System.Windows.Forms.Padding(30, 3, 3, 30);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(911, 242);
            this.roundButton4.TabIndex = 2;
            this.roundButton4.TextColor = System.Drawing.Color.White;
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // PanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(919, 548);
            this.Controls.Add(this.contenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelControl";
            this.contenido.ResumeLayout(false);
            this.contenedor_paneles.ResumeLayout(false);
            this.contenedor_paneles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenido;
        private System.Windows.Forms.Panel contenedor_paneles;
        private System.Windows.Forms.Label label2;
        private APP_BANCO.RoundButton roundButton10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private APP_BANCO.RoundButton roundButton9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private APP_BANCO.RoundButton roundButton8;
        private System.Windows.Forms.Label label3;
        private APP_BANCO.RoundButton roundButton5;
        private APP_BANCO.RoundButton roundButton6;
        private APP_BANCO.RoundButton roundButton7;
        private System.Windows.Forms.Label label15;
        private APP_BANCO.RoundButton roundButton4;
    }
}