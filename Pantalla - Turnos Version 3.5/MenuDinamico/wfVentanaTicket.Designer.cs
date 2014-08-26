namespace MenuDinamico
{
    partial class wfVentanaTicket
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblTituloTurno = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.lblTick = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDiaS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTurno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MenuDinamico.Properties.Resources.Bienvenido___1___2___3;
            this.pictureBox2.Location = new System.Drawing.Point(22, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 141);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlMenu.Controls.Add(this.lblTurno);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.lblDiaS);
            this.pnlMenu.Controls.Add(this.lblFecha);
            this.pnlMenu.Controls.Add(this.lblMin);
            this.pnlMenu.Controls.Add(this.lblTick);
            this.pnlMenu.Controls.Add(this.lblHora);
            this.pnlMenu.Controls.Add(this.lblTituloTurno);
            this.pnlMenu.Location = new System.Drawing.Point(460, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(350, 606);
            this.pnlMenu.TabIndex = 2;
            // 
            // lblTituloTurno
            // 
            this.lblTituloTurno.AutoSize = true;
            this.lblTituloTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTurno.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTituloTurno.Location = new System.Drawing.Point(3, 9);
            this.lblTituloTurno.Name = "lblTituloTurno";
            this.lblTituloTurno.Size = new System.Drawing.Size(163, 55);
            this.lblTituloTurno.TabIndex = 0;
            this.lblTituloTurno.Text = "Turno:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft JhengHei UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHora.Location = new System.Drawing.Point(3, 397);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(125, 122);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "H";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.BackColor = System.Drawing.Color.Transparent;
            this.lblTick.Font = new System.Drawing.Font("Microsoft JhengHei UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTick.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTick.Location = new System.Drawing.Point(122, 397);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(74, 122);
            this.lblTick.TabIndex = 2;
            this.lblTick.Text = ":";
            this.lblTick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMin.Location = new System.Drawing.Point(165, 397);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(145, 122);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "M";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecha.Location = new System.Drawing.Point(27, 556);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 26);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDiaS
            // 
            this.lblDiaS.AutoSize = true;
            this.lblDiaS.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDiaS.Location = new System.Drawing.Point(28, 519);
            this.lblDiaS.Name = "lblDiaS";
            this.lblDiaS.Size = new System.Drawing.Size(158, 35);
            this.lblDiaS.TabIndex = 5;
            this.lblDiaS.Text = "DiaSemana";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(24, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(163, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTurno.Location = new System.Drawing.Point(16, 82);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(304, 91);
            this.lblTurno.TabIndex = 8;
            this.lblTurno.Text = "SV-001";
            // 
            // wfVentanaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::MenuDinamico.Properties.Resources.Fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wfVentanaTicket";
            this.ShowInTaskbar = false;
            this.Text = "Bienvenidos Clientes";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblTituloTurno;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblTick;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDiaS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTurno;





    }
}

