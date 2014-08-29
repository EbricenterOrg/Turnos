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
    public partial class wfReporteareasmasvisistadas : Form
    {
        public wfReporteareasmasvisistadas()
        {
            InitializeComponent();
        }

        private void wfReporteareasmasvisistadas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dt_dataset.DataTable2' Puede moverla o quitarla según sea necesario.
            this.DataTable2TableAdapter.Fill(this.dt_dataset.DataTable2);

            this.reportViewer1.RefreshReport();
        }
    }
}
