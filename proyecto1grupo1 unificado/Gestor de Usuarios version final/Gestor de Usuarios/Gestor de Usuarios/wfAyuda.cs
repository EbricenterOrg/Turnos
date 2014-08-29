/*Autor: "Cristian Portillo"
 *Fecha " Agosto 2014"
 *Comentario: "Modulo ayuda"
 *Estandarizado por: "Jessica Castellanos"
 *Fecha estandarizacion: 27 Agosto 2014*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestor_de_Usuarios
{
    public partial class wfAyuda : Form
    {
        public wfAyuda()
        {
            InitializeComponent();
        }

        private void btnManualusuario_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "C:/Users/Jessica/Desktop/proyecto1grupo1 unificado/proyecto1grupo1_Version4 admin&gestion&reportes unificados/proyecto1grupo1/bin/Debug/manualdeusuario.pdf";
            proc.Start();
            proc.Close();
        }

        private void wfAyuda_Load(object sender, EventArgs e)
        {

        }

        private void btnManualtecnico_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "C:/Users/Jessica/Desktop/proyecto1grupo1 unificado/proyecto1grupo1_Version4 admin&gestion&reportes unificados/proyecto1grupo1/bin/Debug/manualtecnico.pdf";
            proc.Start();
            proc.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
