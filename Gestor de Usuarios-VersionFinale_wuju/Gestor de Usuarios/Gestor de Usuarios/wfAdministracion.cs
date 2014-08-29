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
    public partial class wfAdministracion : Form
    {
        private MySqlConnection SQL_Conexion = new MySqlConnection();
        private String connectionString;
        wfAgregarArea agregarArea = new wfAgregarArea();

        public wfAdministracion()
        {
            InitializeComponent();
        }

      

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            wfAgregarUsuarios FrmNuevoUsuario = new wfAgregarUsuarios();
            FrmNuevoUsuario.Show();
            this.Hide();
        }

        private void btnModificarUser_Click(object sender, EventArgs e)
        {
            wfModificarUsuarios wfModificar = new wfModificarUsuarios();
            wfModificar.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            wfEliminarUsuario wfEliminar = new wfEliminarUsuario();
            wfEliminar.Show();
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string S_Cconn = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";

                MySqlConnection SQL_conexion = new MySqlConnection();
                SQL_conexion.ConnectionString = S_Cconn;
               
                SQL_conexion.Open();
                MySqlDataAdapter SQL_da = new MySqlDataAdapter("Select * from tabm_usuario", SQL_conexion);
                DataTable DT_dat = new DataTable();
                SQL_da.Fill(DT_dat);
                this.dgvUsuarios.DataSource = DT_dat;
                SQL_conexion.Close();
 

                //Numero de usuarios en el sistema
                SQL_conexion.Open();
                MySqlCommand SQL_cmd = new MySqlCommand("select count(id_usuario)as Cuenta_users from tabm_usuario ", SQL_conexion);
                MySqlDataReader dataReader = SQL_cmd.ExecuteReader();
                while (dataReader.Read()) { lblTotal.Text = dataReader["Cuenta_users"] + ""; }
                SQL_conexion.Close();

                //Numero Usuarios Administrador
                SQL_conexion.Open();
                MySqlCommand SQL_Permiso1 = new MySqlCommand("select count(usur_permiso)as Permiso_user from tabm_usuario where usur_Permiso= 1", SQL_conexion);
                MySqlDataReader dRPermiso = SQL_Permiso1.ExecuteReader();
                while (dRPermiso.Read()) { lblAdmin.Text = dRPermiso["Permiso_user"] + ""; }
                SQL_conexion.Close();

                //numero Usuarios Ventanilla
                SQL_conexion.Open();
                MySqlCommand SQL_Permiso2 = new MySqlCommand("select count(usur_permiso)as Permiso_user from tabm_usuario where usur_Permiso= 2", SQL_conexion);
                MySqlDataReader dRPermiso2 = SQL_Permiso2.ExecuteReader();
                while (dRPermiso2.Read()) { lblNormales.Text = dRPermiso2["Permiso_user"] + ""; }
                SQL_conexion.Close();

                //Numero Usuarios Activos
                SQL_conexion.Open();
                MySqlCommand SQL_Estado = new MySqlCommand("select count(usur_estado)as usur_estado from tabm_usuario where usur_estado= 'Activo'" , SQL_conexion);
                MySqlDataReader dREstado = SQL_Estado.ExecuteReader();
                while (dREstado.Read()) { lblActivos.Text = dREstado["usur_estado"] + ""; }
                SQL_conexion.Close();
               


            }
            catch (Exception ei)
            {
                MessageBox.Show("Ocurrio un error" + ei.Message);
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string S_Cconn = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";

                MySqlConnection SQL_conexion = new MySqlConnection();
                SQL_conexion.ConnectionString = S_Cconn;
                SQL_conexion.Open();
                MySqlDataAdapter SQL_da = new MySqlDataAdapter("Select * from  tabm_usuario WHERE id_usuario='" + txbBuscarUsuario.Text + "'", SQL_conexion);
                DataTable DT_dat = new DataTable();
                SQL_da.Fill(DT_dat);
                this.dgvUsuarios.DataSource = DT_dat;

                SQL_conexion.Close();
            }
            catch (Exception ei)
            {
                MessageBox.Show("Ocurrio un error" + ei.Message);
            }
        }

        private void FrmAdministracion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregarArea.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wfEliminarAreacs EliminarArea = new wfEliminarAreacs();
            this.Hide();
            EliminarArea.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wfModificarArea moduloArea = new wfModificarArea();
            this.Hide();
            moduloArea.Show();
        }

       
       

    }
}
