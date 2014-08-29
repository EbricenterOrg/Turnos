namespace Gestor_de_Usuarios
{
    partial class wfAyuda
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnManualtecnico = new System.Windows.Forms.Button();
            this.btnManualusuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manuales gestion de turnos";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Gestor_de_Usuarios.Properties.Resources.cerrar_borrar_la_salida_icono_9027_64;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(715, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 49);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnManualtecnico
            // 
            this.btnManualtecnico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManualtecnico.BackgroundImage = global::Gestor_de_Usuarios.Properties.Resources.tecnicmanual;
            this.btnManualtecnico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManualtecnico.Location = new System.Drawing.Point(462, 212);
            this.btnManualtecnico.Name = "btnManualtecnico";
            this.btnManualtecnico.Size = new System.Drawing.Size(234, 255);
            this.btnManualtecnico.TabIndex = 1;
            this.btnManualtecnico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManualtecnico.UseVisualStyleBackColor = false;
            this.btnManualtecnico.Click += new System.EventHandler(this.btnManualtecnico_Click);
            // 
            // btnManualusuario
            // 
            this.btnManualusuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManualusuario.BackgroundImage = global::Gestor_de_Usuarios.Properties.Resources.usermanual;
            this.btnManualusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManualusuario.Location = new System.Drawing.Point(101, 212);
            this.btnManualusuario.Name = "btnManualusuario";
            this.btnManualusuario.Size = new System.Drawing.Size(215, 255);
            this.btnManualusuario.TabIndex = 0;
            this.btnManualusuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManualusuario.UseVisualStyleBackColor = false;
            this.btnManualusuario.Click += new System.EventHandler(this.btnManualusuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manual de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manual técnico";
            // 
            // wfAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnManualtecnico);
            this.Controls.Add(this.btnManualusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wfAyuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wfAyuda";
            this.Load += new System.EventHandler(this.wfAyuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManualusuario;
        private System.Windows.Forms.Button btnManualtecnico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}