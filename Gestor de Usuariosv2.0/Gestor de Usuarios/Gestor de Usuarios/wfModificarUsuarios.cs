using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestor_de_Usuarios
{
    public partial class wfModificarUsuarios : Form
    {
        private MySqlConnection SQL_Conexion = new MySqlConnection();
        private String connectionString;
        private MySqlCommand SQL_cmd;

        public wfModificarUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //try
            //{
                String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                SQL_Conexion.ConnectionString = S_cadena;
               /* SQL_Conexion.Open();


                SQL_cmd = new MySqlCommand("UPDATE tabm_usuario SET usur_nom=\"" + txtNombre.Text + "\",usur_ape=\"" + txtApellido.Text + "\",usur_ape_cas=\"" + txtApeCasada.Text + "\",usur_permiso=\"" + cboPermiso.Text + "\",usur_dir=\"" + txtDireccion.Text + "\",usur_tel=\"" + txtTelefono.Text + "\",usur_mail=\"" + txtCorreo.Text + "\",usur_pass=\"" + txtPass.Text + "\",usur_estado=\"" + cboEstado.Text + "\" WHERE id_usuario=\"" + txtIdUsuario.Text + "\"", SQL_Conexion);
               
                SQL_cmd.ExecuteNonQuery();
                SQL_Conexion.Close();
            */
                //Numero de usuarios en el sistema

                SQL_Conexion.Open();
                MySqlCommand SQL_cmd = new MySqlCommand("Select * from tab_usuario WHERE id_usuario=\"" + txtIdUsuario.Text + "\"", SQL_conexion);
                MySqlDataReader dataReader = SQL_cmd.ExecuteReader();
                while (dataReader.Read()) { lblTotal.Text = dataReader["Cuenta_users"] + ""; }
                SQL_conexion.Close();

                MessageBox.Show("Usuario modificado exitosamente ", "Modificacion Cuenta Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtIdUsuario.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtApeCasada.Text = "";
                cboPermiso.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtPass.Text = "";


         
        }
    }
}
