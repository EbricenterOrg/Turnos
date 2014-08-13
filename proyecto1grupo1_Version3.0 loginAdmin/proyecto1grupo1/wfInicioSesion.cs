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
    public partial class wfInicioSesion : Form
    {

        MySqlConnection SQL_Conexion = new MySqlConnection();
        MySqlCommand SQL_cmd;
        public wfInicioSesion()
        {
            InitializeComponent();
        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {

            
                wfInicioSesion frm = new wfInicioSesion();
                wfMenuTurnos wfMenuTurnos = new wfMenuTurnos();
                wfPantallaTurnos wfPantallaTurnos = new wfPantallaTurnos();
                int contadorInicioSesion=0;
                String cportillo = "cportillo";
                String jessi014 = "jessi014";
                String Leonel071 = "Leonel071";



             try
                {
                    String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                    SQL_Conexion.ConnectionString = S_cadena;
                    SQL_Conexion.Open();
                    SQL_cmd = new MySqlCommand("Select id_usuario from tabm_usuario WHERE usur_pass='" + textBox2.Text + "'", SQL_Conexion);
                    Object obj = SQL_cmd.ExecuteScalar();



                    if (obj == null)
                    {
                        MessageBox.Show("El  usuario y/o contraseña son invalidos validos, intente de nuevo", "Error de Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        contadorInicioSesion += 1;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        SQL_Conexion.Close();


                    }

                    else if (obj.ToString() == cportillo)
                    {
                        MessageBox.Show("Cristian Portillo Bienvenido al sistema, habilitando ventana cliente... ", "Bienvenido al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        SQL_Conexion.Close();
                        this.Hide();
                        wfMenuTurnos.Show();
                        wfPantallaTurnos.Show();
                        
                        //wfPantallaTurnos.ayudaToolStripMenuItem.Enabled = false; AQUI VA LO DEL ENABLED



                    }

                    else if (obj.ToString() == jessi014)
                    {
                        MessageBox.Show("Jessica Castellanos Bienvenida al sistema, Habilitando Terminal Tonta ", "Bienvenido al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        SQL_Conexion.Close();
                        this.Hide();
                        wfMenuTurnos.Show();
                        wfPantallaTurnos.Show();
                    }

                    else if (obj.ToString() == Leonel071)
                    {
                        MessageBox.Show("Jorge Lam, Bienvenido al sistema, Habilitando ventana administrador...", "Bienvenido al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        SQL_Conexion.Close();
                        this.Hide();
                        wfMenuTurnos.Show();
                        wfPantallaTurnos.Show();
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
