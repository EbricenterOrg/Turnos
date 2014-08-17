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
using System.Data.SqlClient;

namespace proyecto1grupo1
{
    public partial class wfInicioSesion : Form
    {

       private MySqlConnection SQL_Conexion = new MySqlConnection();
       private String connectionString;
       private MySqlCommand SQL_cmd;

        int contadorInicioSesion=0;


        public wfInicioSesion()
        {
            InitializeComponent();
        }

         

        private void button1_Click(object sender, EventArgs e)
        {        

            wfInicioSesion frmSesion = new wfInicioSesion();
            wfMenuTurnos frmTurno = new wfMenuTurnos();
            wfPantallaTurnos frmPantalla = new wfPantallaTurnos();
            wfTerminal frmTerminal = new wfTerminal();
           
                try
                {
                    String S_cadena = "Server=192.168.1.100;User ID= root; Database= bd_turnos; Password=GrupoSGT014;";                   
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

                             MySqlDataAdapter SQL_datos = new MySqlDataAdapter("Select TP.perm_tipo, TP.usur_id from tabm_usuario TU INNER JOIN tab_permiso TP ON TP.usur_id = TU.id_usuario where TU.usur_pass='"+textBox2.Text+"' and TU.id_usuario= '"+textBox1.Text+"';", SQL_Conexion);
                             DataTable DT_datos = new DataTable();
                             SQL_datos.Fill(DT_datos);
                             MessageBox.Show("Bienvenido al sistema"); 
                             String S_nombre = DT_datos.Rows[0][0].ToString();
                           
                            int i_opc=Convert.ToInt32(S_nombre);

                                 textBox1.Text = "";
                                 textBox2.Text = "";
                                 SQL_Conexion.Close();
                                 this.Hide();
                        switch(i_opc)
                        {
                            case 1: frmPantalla.Show();  
                                    break;
                            case 2: frmTerminal.Show();
                                    break;
                            case 3: frmTurno.Show();
                                    break;
                        
                        }
                                 /*this.Hide();
                                 frm1.Show();
                                 frm2.Show();*/
                            
                           }
                }
                catch (MySqlException)
                {

                }

           
            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void wfInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
