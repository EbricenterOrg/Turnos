/*Autor: "Cristian Portillo"
 *Fecha " Julio 2014"
 *Comentario: "Este modulo mostrara el inicio de sesion del usuario"
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

        MySqlConnection SQL_Conexion = new MySqlConnection();
        String connectionString;
        MySqlCommand SQL_cmd;
        int contadorFilas = 1;
        public static String S_cadena2;

        public wfPantallaTurnos()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wfPantallaTurnos_Load(object sender, EventArgs e)
        {

        }

      
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfAgregarItem wfAgregarItem = new wfAgregarItem();
            wfAgregarItem.Show();

        }

        public void llenarToolstrip(ToolStripMenuItem menutool, object obj) {

            menutool.Text = obj.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            try
            {
                String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                SQL_Conexion.ConnectionString = S_cadena;
                SQL_Conexion.Open();
                SQL_cmd = new MySqlCommand("Select modl_nom from  tabm_modulo WHERE id_modulo='" + contadorFilas + "'", SQL_Conexion);
                Object obj = SQL_cmd.ExecuteScalar();
                if (obj != null)
                {
                    this.ayudaToolStripMenuItem.DropDown.Items.Add(obj.ToString());
                    contadorFilas = contadorFilas + 1;
                    SQL_Conexion.Close();
                }
                else {
                    MessageBox.Show("No hay items que agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SQL_Conexion.Close();
                }

                
            }
            catch { 
            }
        }

        private void DG_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dsaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
