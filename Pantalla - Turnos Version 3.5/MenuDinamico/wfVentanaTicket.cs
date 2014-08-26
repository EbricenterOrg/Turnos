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
using System.Collections;
using dllConnection;
using t_botones;



namespace MenuDinamico
{
    public partial class wfVentanaTicket : Form
    {
        private bool sParpadear = true;

        private System.Windows.Forms.Button[] btnVirtuales = new System.Windows.Forms.Button[9];
      
       
        public wfVentanaTicket()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnVirtuales = new N_Boton().ActualizarTabla();
            for(int cont = 0;cont < btnVirtuales.Count(); cont++)
            {
                this.Controls.Add(btnVirtuales[cont]);
            }
            pos_Menu();

        }

        public void pos_Menu()
        {
            int iPos_x = this.Size.Width - 320;
            int iAlto = this.Size.Height;
            pnlMenu.Location = new Point(iPos_x,0);
            pnlMenu.Size = new System.Drawing.Size(320,iAlto);
            int iPos_y = iAlto - 220;
            lblTick.Location = new Point(130, iPos_y);
            lblHora.Location = new Point(0, iPos_y);
            lblMin.Location  = new Point(170, iPos_y);
            lblFecha.Location = new Point(20, iAlto - 80);
            lblDiaS.Location = new Point(20, iAlto - 120);
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
       
            N_Reloj tiempo = new N_Reloj();
            lblDiaS.Text = tiempo.DiaSemana()+",";
            lblFecha.Text = tiempo.fecha();
            if (sParpadear == true)
            {
                lblHora.Text = tiempo.hora();
                lblMin.Text = tiempo.min();
                lblTick.Text = ":";
                sParpadear = false;
            }
            else 
            {
                lblHora.Text = tiempo.hora();
                lblMin.Text = tiempo.min();
                lblTick.Text = " ";
                sParpadear = true;
            }
                
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

     
    
    }
}
