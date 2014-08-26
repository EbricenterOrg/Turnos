using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreacionPDF
{
    public partial class Form1 : Form
    {
        private PDF pdf;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pdf = new PDF();
            pdf.DocPDF("Turno VS-6", "Ticket VS-6");
        }
    }
}
