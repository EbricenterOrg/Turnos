using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace MenuDinamico
{
    public partial class wfVentanaTicket : Form
    {
        DataRow Renglon;
       
        public wfVentanaTicket()
        {
            InitializeComponent();
           
        }

       

       

 

        public void ActualizarTabla()
        {
            String Nombre;
            try
            {
                string S_Cconn = "Server=192.168.0.100; UID=root; Database=bd_turnos; Password=GrupoSGT014";

                MySqlConnection SQL_conexion = new MySqlConnection();
                SQL_conexion.ConnectionString = S_Cconn;
                SQL_conexion.Open();
                MySqlCommand SQLcmd = new MySqlCommand("SELECT area_abv, area_nom FROM tabm_area", SQL_conexion);
                MySqlDataReader dataReader = SQLcmd.ExecuteReader();

                

                System.Windows.Forms.Button[] btnVirtuales = new System.Windows.Forms.Button[9];

                
                int cont = 0;

                while (dataReader.Read())
                {
                    Nombre = dataReader["area_abv"]+"  "+dataReader["area_nom"] + "";
                    btnVirtuales[cont] = new Button();
                    btnVirtuales[cont].Text = Nombre;
                    btnVirtuales[cont].Location = new System.Drawing.Point(50,150  + cont * 210);
                    btnVirtuales[cont].Height = 200;
                    btnVirtuales[cont].Width = 200;
                    btnVirtuales[cont].BackColor = Color.FromArgb(75,0,130);
                    btnVirtuales[cont].FlatStyle = FlatStyle.Flat;
                    btnVirtuales[cont].FlatAppearance.BorderColor = 
                    btnVirtuales[cont].FlatAppearance.MouseOverBackColor = Color.FromArgb(123,104,238);
                    btnVirtuales[cont].Font = new Font("Arial",18);
                    btnVirtuales[cont].ForeColor = Color.FromArgb(255,255,255);
                    
                    this.Controls.Add(btnVirtuales[cont]);
                    cont++;
                  
                }
               
                
            }
            catch (Exception ei)
            {
                Console.WriteLine(ei.Message);
                MessageBox.Show("Ocurrio un error " + ei.Message, "ERROR");
            }
        

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
