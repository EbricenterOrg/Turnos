/*Autor: "Cristian Portillo"
 *Fecha " Agosto 2014"
 *Comentario: "Modulo modificar area"
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
using MySql.Data.MySqlClient;
using System.IO;

namespace Gestor_de_Usuarios
{
    public partial class wfModificarArea : Form
    {
        private MySqlConnection SQL_Conexion = new MySqlConnection();
        private MySqlCommand SQL_cmd;
        wfAdministracion wfAdmin = new wfAdministracion();

        public wfModificarArea()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try{
                String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                SQL_Conexion.ConnectionString = S_cadena;
                SQL_Conexion.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from  tabm_area WHERE id_area='" + txtIdUsuario.Text + "'", SQL_Conexion);
                
                object objeto = cmd.ExecuteScalar();
                if (objeto == null)
                {
                    MessageBox.Show("Error, El area no existe ", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    txtNombre.Enabled = false;
                    btnCambiarImagen.Enabled=false;
                    btnAgregar.Enabled = false;
                    btnCambiarImagen.Enabled = true;

                }
                else
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        txtNombre.Text = dataReader["area_nom"] + "";

                        btnAgregar.Enabled = true;
                    }
                    dataReader.Close();
                    txtNombre.Enabled = true;

                    btnAgregar.Enabled = true;
                }
                SQL_Conexion.Close();

            }
            catch (Exception ei)
            {

                btnAgregar.Enabled = false;
                MessageBox.Show("Error, El usuario no existe ", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            wfAdmin.Show();

        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            dlg.Title = "Seleccione la imagen del boton";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc = dlg.FileName.ToString();
                txtImagenPath.Text = picLoc;
                pctbAgregarImagen.ImageLocation = picLoc;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            try
            {
                byte[] imageBt = null;
                FileStream fstream = new FileStream(this.txtImagenPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);

                MySqlConnection SQL_Conexion = new MySqlConnection();
                String connectionString;
                MySqlCommand SQL_cmd;
                // cmd = new MySqlCommand(SQL_cmd, SQL_Conexion);
                wfAdministracion wfAdmin = new wfAdministracion();

                String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                SQL_Conexion.ConnectionString = S_cadena;
                SQL_Conexion.Open();
                //SQL_cmd = new MySqlCommand("INSERT INTO tabm_area VALUES  ('"  + txtNombre.Text + "',@IMG)", SQL_Conexion);
                SQL_cmd = new MySqlCommand("UPDATE tabm_usuario SET area_nom=\"" + txtNombre.Text + "\" WHERE id_usuario=\"" + txtIdUsuario.Text + "\"", SQL_Conexion);
               // SQL_cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));

                SQL_cmd.ExecuteNonQuery();
                SQL_Conexion.Close();

                MessageBox.Show("Area Modificada exitosamente ", "Modificacion Area", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
            catch
            {
                MessageBox.Show("Revise sus datos, ingreso no completado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wfModificarArea_Load(object sender, EventArgs e)
        {

        }
    }
}
