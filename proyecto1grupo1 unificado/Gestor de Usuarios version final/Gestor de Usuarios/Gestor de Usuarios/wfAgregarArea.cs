/*Autor: "Cristian Portillo"
 *Fecha " Agosto 2014"
 *Comentario: "Modulo agregar area"
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
    public partial class wfAgregarArea : Form
    {
        

        
        public wfAgregarArea()
        {
            InitializeComponent();
        }
      
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            wfAdministracion Administracion = new wfAdministracion();
            this.Hide();
            Administracion.Show();
        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            dlg.Title="Seleccione la imagen del boton";
            if(dlg.ShowDialog()==DialogResult.OK){
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
                FileStream fstream = new FileStream(this.txtImagenPath.Text,FileMode.Open,FileAccess.Read);
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
                SQL_cmd = new MySqlCommand("INSERT INTO tabm_area VALUES  ('" + txtIdArea.Text + "','" + txtNombre.Text + "',@IMG)", SQL_Conexion);

                SQL_cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));

                SQL_cmd.ExecuteNonQuery();
                SQL_Conexion.Close();

                MessageBox.Show("Area insertada exitosamente ", "Creacion Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
                



            }
            catch 
            {
                MessageBox.Show("Revise sus datos, ingreso no completado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wfAgregarArea_Load(object sender, EventArgs e)
        {

        }
    }
}
