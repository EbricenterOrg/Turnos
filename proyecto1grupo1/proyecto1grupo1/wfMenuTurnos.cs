using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;  //Permite leer el texto
using System.Speech.Recognition; //permite Reconocer la voz
using System.Threading;

namespace proyecto1grupo1
{
   
    public partial class wfMenuTurnos : Form
    {
        int gbIContadorReparacion = 0;
        int gbIContadorVentas = 0;
        int gbIContadorAtencion = 0;
        int gbIContadorPagos = 0;



        wfInicioSesion frmInicio = new wfInicioSesion(); 
        wfPantallaTurnos frmEspera= new wfPantallaTurnos();


        public wfMenuTurnos()
        {
            InitializeComponent();

            timer1.Start();
        }
 
       
        SpeechSynthesizer sSynth = new SpeechSynthesizer();// 
        PromptBuilder pBuilder = new PromptBuilder();// Promtp que nos dice que hablar
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        
        

        public void csHablar() {
            pBuilder.ClearContent(); // limpia el contenido que sera escrito
                 pBuilder.AppendText(textBox1.Text);
                    sSynth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                    sSynth.Rate = -5;
                //sSynth.GetInstalledVoices(new System.Globalization.CultureInfo("es-ES"));  //ESTE ES PARA IDIOMA
            sSynth.Speak(pBuilder);
        }



        private void btnReparacion_Click(object sender, EventArgs e)
        {
            gbIContadorReparacion += 1;
                 textBox1.AppendText("Su turno es: R,E," + gbIContadorReparacion);
                 csHablar();
                 MessageBox.Show("Su turno es: RE-" + gbIContadorReparacion);
            textBox1.Text = "";
        }



        private void btnAtencion_Click(object sender, EventArgs e)
        {
            gbIContadorAtencion += 1;
            textBox1.AppendText("Su turno es: A,T," + gbIContadorAtencion);
            csHablar();
            MessageBox.Show("Su turno es: AT- " + gbIContadorAtencion);
            textBox1.Text = "";
        }



        private void btnVentas_Click(object sender, EventArgs e)
        {
            gbIContadorVentas += 1;
            textBox1.AppendText("Your Turn is: V,E," + gbIContadorVentas);
            csHablar();
            MessageBox.Show("Su turno es: VE-" + gbIContadorVentas);
            textBox1.Text = "";
        }



        private void btnPagos_Click(object sender, EventArgs e)
        {
            gbIContadorPagos += 1;
            textBox1.AppendText("Your Turn is: P,A," + gbIContadorPagos);
            csHablar();
            MessageBox.Show("Su turno es: PA-" + gbIContadorPagos);
            textBox1.Text = "";
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblHora.Text = dateTime.ToString();
        }



        private void lblHora_Click(object sender, EventArgs e)
        {

        }

      

       
   
       
      
    }
}
