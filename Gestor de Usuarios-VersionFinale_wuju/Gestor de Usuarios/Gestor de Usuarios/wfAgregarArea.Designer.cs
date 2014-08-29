namespace Gestor_de_Usuarios
{
    partial class wfAgregarArea
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdArea = new System.Windows.Forms.TextBox();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctbAgregarImagen = new System.Windows.Forms.PictureBox();
            this.txtImagenPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbAgregarImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtIdArea
            // 
            this.txtIdArea.Location = new System.Drawing.Point(12, 36);
            this.txtIdArea.Name = "txtIdArea";
            this.txtIdArea.Size = new System.Drawing.Size(300, 20);
            this.txtIdArea.TabIndex = 0;
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCambiarImagen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnCambiarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCambiarImagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCambiarImagen.Location = new System.Drawing.Point(137, 186);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(106, 41);
            this.btnCambiarImagen.TabIndex = 2;
            this.btnCambiarImagen.Text = "Seleccionar  Imagen";
            this.btnCambiarImagen.UseVisualStyleBackColor = false;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Imagen del Area";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre del Area";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Id Area";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-1, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 24);
            this.label1.TabIndex = 22;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(115, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTitulo.Location = new System.Drawing.Point(-5, 324);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 39);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "Agregar Area";
            // 
            // pctbAgregarImagen
            // 
            this.pctbAgregarImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctbAgregarImagen.Location = new System.Drawing.Point(15, 161);
            this.pctbAgregarImagen.Name = "pctbAgregarImagen";
            this.pctbAgregarImagen.Size = new System.Drawing.Size(106, 101);
            this.pctbAgregarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbAgregarImagen.TabIndex = 18;
            this.pctbAgregarImagen.TabStop = false;
            // 
            // txtImagenPath
            // 
            this.txtImagenPath.Location = new System.Drawing.Point(15, 268);
            this.txtImagenPath.Name = "txtImagenPath";
            this.txtImagenPath.Size = new System.Drawing.Size(106, 20);
            this.txtImagenPath.TabIndex = 57;
            this.txtImagenPath.Visible = false;
            // 
            // wfAgregarArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 384);
            this.Controls.Add(this.txtImagenPath);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdArea);
            this.Controls.Add(this.btnCambiarImagen);
            this.Controls.Add(this.pctbAgregarImagen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "wfAgregarArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Area";
            ((System.ComponentModel.ISupportInitialize)(this.pctbAgregarImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdArea;
        private System.Windows.Forms.Button btnCambiarImagen;
        private System.Windows.Forms.PictureBox pctbAgregarImagen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtImagenPath;
    }
}