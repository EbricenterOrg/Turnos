namespace Gestor_de_Usuarios
{
    partial class wfEliminarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEliminarUsuario));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pboUsuario = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTitulo.Location = new System.Drawing.Point(131, 354);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 39);
            this.lblTitulo.TabIndex = 77;
            this.lblTitulo.Text = "Eliminar Cuenta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(570, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 23);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(471, 316);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 23);
            this.btnEliminar.TabIndex = 75;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pboUsuario
            // 
            this.pboUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pboUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pboUsuario.Image")));
            this.pboUsuario.Location = new System.Drawing.Point(471, 150);
            this.pboUsuario.Name = "pboUsuario";
            this.pboUsuario.Size = new System.Drawing.Size(173, 138);
            this.pboUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboUsuario.TabIndex = 74;
            this.pboUsuario.TabStop = false;
            this.pboUsuario.Click += new System.EventHandler(this.pboUsuario_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel8.Location = new System.Drawing.Point(120, 396);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(539, 23);
            this.panel8.TabIndex = 94;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(60, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Usuario:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(157, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 21);
            this.panel1.TabIndex = 96;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(157, 177);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(271, 20);
            this.txtIdUsuario.TabIndex = 95;
            // 
            // wfEliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pboUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wfEliminarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Usuario";
            this.Load += new System.EventHandler(this.wfEliminarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pboUsuario;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdUsuario;
    }
}