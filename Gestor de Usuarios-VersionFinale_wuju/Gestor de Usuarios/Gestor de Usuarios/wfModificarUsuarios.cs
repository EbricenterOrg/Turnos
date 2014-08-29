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
        private MySqlCommand SQL_cmd;
        wfAdministracion wfAdmin = new wfAdministracion();

        public wfModificarUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                SQL_Conexion.ConnectionString = S_cadena;
                SQL_Conexion.Open();


                SQL_cmd = new MySqlCommand("UPDATE tabm_usuario SET usur_nom=\"" + txtNombre.Text + "\",usur_ape=\"" + txtApellido.Text + "\",usur_ape_cas=\"" + txtApeCasada.Text + "\",usur_permiso=\"" + cboPermiso.Text + "\",usur_dir=\"" + txtDireccion.Text + "\",usur_tel=\"" + txtTelefono.Text + "\",usur_mail=\"" + txtCorreo.Text + "\",usur_pass=\"" + txtPass.Text + "\",usur_estado=\"" + cboEstado.Text + "\" WHERE id_usuario=\"" + txtIdUsuario.Text + "\"", SQL_Conexion);

                

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
                    cboEstado.Text = "";


                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtApeCasada.Enabled = false;
                    cboPermiso.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtPass.Enabled = false;
                    cboEstado.Enabled = false;
                    btnAgregar.Enabled = false;

                    txtIdUsuario.Enabled = true;
                    SQL_cmd.ExecuteNonQuery();
                SQL_Conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error, Actualizacion no realizada ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            wfAdmin.Show();


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try{
                String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                SQL_Conexion.ConnectionString = S_cadena;
                SQL_Conexion.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from  tabm_usuario WHERE id_usuario='" + txtIdUsuario.Text + "'", SQL_Conexion);
                
                object objeto = cmd.ExecuteScalar();
                if (objeto == null)
                {
                    MessageBox.Show("Error, El usuario no existe ", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnAgregar.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtApeCasada.Enabled = false;
                    cboPermiso.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtPass.Enabled = false;
                    cboEstado.Enabled = false;
                    btnAgregar.Enabled = false;
                }
                else
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        txtNombre.Text = dataReader["usur_nom"] + "";
                        txtApellido.Text = dataReader["usur_ape"] + "";
                        txtApeCasada.Text = dataReader["usur_ape_cas"] + "";
                        cboPermiso.Text = dataReader["usur_permiso"] + "";
                        txtDireccion.Text = dataReader["usur_dir"] + "";
                        txtTelefono.Text = dataReader["usur_tel"] + "";
                        txtCorreo.Text = dataReader["usur_mail"] + "";
                        txtPass.Text = dataReader["usur_pass"] + "";
                        cboEstado.Text = dataReader["usur_estado"] + "";
                        btnAgregar.Enabled = true;
                    }
                    dataReader.Close();
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtApeCasada.Enabled = true;
                    cboPermiso.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtPass.Enabled = true;
                    cboEstado.Enabled = true;
                    btnAgregar.Enabled = true;
                    txtIdUsuario.Enabled = false;
                }
                SQL_Conexion.Close();
       
            }
            catch (Exception ei)
            {

                btnAgregar.Enabled = false;
                MessageBox.Show("Error, El usuario no existe ", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }
    }
