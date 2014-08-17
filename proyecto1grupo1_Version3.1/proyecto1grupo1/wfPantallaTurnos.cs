/*Autor: "Cristian Portillo"
 *Fecha " Julio 2014"
 *Comentario: "Este modulo mostrara el inicio de sesion del usuario,"
 *Estandarizado por: "Jessica Castellanos"
 *Fecha estandarizacion: 10 Agosto 2014*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyecto1grupo1
{
    public partial class wfPantallaTurnos : Form
    {
        private MySqlConnection SQL_Conexion = new MySqlConnection();
        private String connectionString;
        private MySqlCommand SQL_cmd;
        private int i_contadorFilas = 1;
        public wfPantallaTurnos()
        {
            InitializeComponent();            
            
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wfPantallaTurnos_Load(object sender, EventArgs e)
        {
            //pr_agregarservicios();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfAcercade frmhijo= new wfAcercade();
            frmhijo.MdiParent=this;
            frmhijo.Show();

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
             
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfOpciones frmhijoP = new wfOpciones("P");
            frmhijoP.MdiParent = this;
            frmhijoP.Text = "Pagos";
            frmhijoP.lblGestion.Text = "Gestion de Turnos";
            frmhijoP.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agregarServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfAgregarItem frmhijo = new wfAgregarItem();
            frmhijo.MdiParent = this;
            frmhijo.Show();
            pr_agregarservicios();
        }

        private void pr_agregarservicios()
        {


            try
            {
                String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                SQL_Conexion.ConnectionString = S_cadena;
                SQL_Conexion.Open();
                SQL_cmd = new MySqlCommand("Select modl_nom from  tabm_modulo WHERE id_modulo='" + i_contadorFilas + "'", SQL_Conexion);
                Object obj = SQL_cmd.ExecuteScalar();
                if (obj != null)
                {
                    this.ayudaToolStripMenuItem.DropDown.Items.Add(obj.ToString());
                    i_contadorFilas = i_contadorFilas + 1;
                    SQL_Conexion.Close();
                }
                else
                {
                    MessageBox.Show("No hay items que agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SQL_Conexion.Close();
                }


            }
            catch
            {
            }
        }

       
    }
}
