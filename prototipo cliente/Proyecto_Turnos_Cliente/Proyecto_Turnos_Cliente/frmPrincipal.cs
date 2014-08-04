using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
  Autor: "Jaime Muñoz"
  Fecha: "31/Julio/2014
  Comentario: Este Form Maneja lo que es El menu principal 
 */ 
namespace Proyecto_Turnos_Cliente
{
    public partial class frmPrincipal : Form
    {


        private string prueba;       
        
        public frmPrincipal(string Sparametro)
        {
            InitializeComponent();
            this.prueba = Sparametro;
            
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpciones frmhijoR = new frmOpciones("R");  
            frmhijoR.MdiParent=this;
            frmhijoR.Text = "Reparacion";
            
            frmhijoR.lblReparacion.Text = "Gestion de Turnos de Reparacion";
            frmhijoR.Show();
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpciones frmhijoA = new frmOpciones("AC");
            frmhijoA.MdiParent = this;
            frmhijoA.Text = "Atencion al Cliente";            
            frmhijoA.lblReparacion.Text = "Gestion de Turnos de Atención al Cliente";
            frmhijoA.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpciones frmhijoV = new frmOpciones("V");
            frmhijoV.MdiParent = this;
            frmhijoV.Text = "Ventas";
            frmhijoV.lblReparacion.Text = "Gestion de Turnos de Ventas";
            frmhijoV.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpciones frmhijoP = new frmOpciones("P");
            frmhijoP.MdiParent = this;
            frmhijoP.Text = "Pagos";
            frmhijoP.lblReparacion.Text = "Gestion de Turnos de Pagos";
            frmhijoP.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblprueba.Text = "esto es una " + prueba;
        }

        private void lblprueba_Click(object sender, EventArgs e)
        {

        }
    }
}
