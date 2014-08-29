/*Autor: "Cristian Portillo"
 *Fecha " Agosto 2014"
 *Comentario: "Modulo eliminar area"
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
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestor_de_Usuarios
{
    public partial class wfEliminarAreacs : Form
    {
        public wfEliminarAreacs()
        {
            InitializeComponent();
        }
        private MySqlConnection SQL_Conexion = new MySqlConnection();
        private String connectionString;
        private MySqlCommand SQL_cmd;
        wfAdministracion wfAdmin = new wfAdministracion();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                SQL_Conexion.ConnectionString = S_cadena;
                SQL_Conexion.Open();
                SQL_cmd = new MySqlCommand("Delete  from  tabm_area WHERE id_area='" + txtIdArea.Text + "'", SQL_Conexion);
                SQL_cmd.ExecuteNonQuery();
                SQL_Conexion.Close();

                MessageBox.Show("Area Eliminada exitosamente ", "Eliminacion de Areas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtIdArea.Text = "";



            }
            catch (MySqlException)
            {
                MessageBox.Show("Error  no se pudo eliminar el area, revise sus datos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            wfAdministracion Admin = new wfAdministracion();
            this.Hide();
            Admin.Show();
        }

        private void wfEliminarAreacs_Load(object sender, EventArgs e)
        {

        }
    }
}
