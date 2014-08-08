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
    public partial class wfInicioSesion : Form
    {

        MySqlConnection SQL_Conexion = new MySqlConnection();
        String connectionString;
        MySqlCommand SQL_cmd;

        int contadorInicioSesion=0;


        public wfInicioSesion()
        {
            InitializeComponent();
        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {

          

            wfInicioSesion frm = new wfInicioSesion();
            wfMenuTurnos frm1 = new wfMenuTurnos();
            wfPantallaTurnos frm2 = new wfPantallaTurnos();


            try
            {
                String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                
                SQL_Conexion.ConnectionString = S_cadena;
                SQL_Conexion.Open();
                SQL_cmd = new MySqlCommand("Select id_usuario from tabm_usuario WHERE usur_pass='" + textBox2.Text + "'", SQL_Conexion);

                Object obj = SQL_cmd.ExecuteScalar();
                if (obj == null)
                {
                    MessageBox.Show("Error", "El  usuario y contraseña son invalidos validos, intente de nuevo");
                    contadorInicioSesion += 1;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    SQL_Conexion.Close();

                   
                }
                else
                {
                    MessageBox.Show("Informacion", "Bienvenido, al sistema");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    SQL_Conexion.Close();
                    this.Hide();
                    frm1.Show();
                    frm2.Show();
                }
            }
            catch (MySqlException)
            {
               
            }


            
            
        }
    }
}
