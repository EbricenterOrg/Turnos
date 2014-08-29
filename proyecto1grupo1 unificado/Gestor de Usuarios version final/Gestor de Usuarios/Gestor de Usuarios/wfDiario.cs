/*Autor: "Cristian Portillo"
 *Fecha " Agosto 2014"
 *Comentario: "Modulo administrador"
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
    public partial class wfDiario : Form
    {
        public wfDiario()
        {
            InitializeComponent();
        }

        private void wfDiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dt_dataset.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.dt_dataset.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
