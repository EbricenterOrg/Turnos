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
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
namespace Servidor_1
{
    public partial class frmVentana : Form
    {
        byte[] b_textorecivido;
        Socket S;
        IPEndPoint Direccion;
        SpeechSynthesizer sSynth = new SpeechSynthesizer();// 
        PromptBuilder pBuilder = new PromptBuilder();// Promtp que nos dice que hablar
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        
        public frmVentana()
        {
            InitializeComponent();
            S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Direccion = new IPEndPoint(IPAddress.Any, 1234);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Hablar()
        {
            pBuilder.ClearContent(); // limpia el contenido que sera escrito
            pBuilder.AppendText( lblgestion.Text);
            sSynth.GetInstalledVoices(new System.Globalization.CultureInfo("es-ES"));  //ESTE ES PARA IDIOMA
            sSynth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);  
            sSynth.Rate = -5;
            sSynth.Speak(pBuilder);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Direccion = new IPEndPoint(IPAddress.Any, 1234);  
            try
            {
                S.Bind(Direccion);
                S.Listen(1);
               Socket Escuchar = S.Accept();
                b_textorecivido = new byte[255];
                int num = Escuchar.Receive(b_textorecivido, 0, b_textorecivido.Length, 0);
                Array.Resize(ref b_textorecivido,num);
                lblgestion.Text= "Turno "+Encoding.Default.GetString(b_textorecivido);
                Hablar();
                S.Close();

            }
            catch { 
            
            }
        }
    }
}
