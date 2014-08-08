/*Autor: "Jaime Muñoz"
 *Fecha "31 Julio 2014"
 *Comentario: "Este form maneja lo que es el control de turnos"
 *Estandarizado por: "Jessica Castellanos"
 *Fecha estandarizacion: 7 Agosto 2014*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Proyecto_Turnos_Cliente
{
    
    public partial class frmOpciones : Form
    {

        private int Icontador=1;
        private byte[] Btextoenviar;
        private String Sopcion;
        public frmOpciones(String Sdatos)
        {            
            InitializeComponent();
            Sopcion = Sdatos;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmReparacion_Load(object sender, EventArgs e)
        {

        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Socket Ssock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPEdireccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            Icontador = Icontador - 1;
            String Stexto = Sopcion +"-"+Icontador.ToString();


            try
            {

                Ssock.Connect(IPEdireccion);
                Btextoenviar = Encoding.Default.GetBytes(Stexto);
                Ssock.Send(Btextoenviar, 0, Btextoenviar.Length, 0);
                //MessageBox.Show("Has dicho no");
                Icontador++;
                
            }
            catch
            {

            }
            Ssock.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Socket Ssock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPEdireccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            String Stexto = Sopcion +"-"+ Icontador.ToString();
         

            try
            {

                Ssock.Connect(IPEdireccion);
                Btextoenviar = Encoding.Default.GetBytes(Stexto);
                Ssock.Send(Btextoenviar, 0, Btextoenviar.Length, 0);
                //MessageBox.Show("Has dicho no");
                Icontador++;
            }
            catch
            {

            }
            Ssock.Close();
        }
    }
}
