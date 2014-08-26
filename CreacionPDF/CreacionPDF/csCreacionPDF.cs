using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
	

namespace CreacionPDF
{
    class PDF
    {
        public PDF()
        { 
        
        }

        public void DocPDF(String S_Cadena, String S_NombrePDF)
        {
            try
            {
                if (!(Directory.Exists(@"C:/Users/Orochi/Desktop/Ticket/")))
                {
                    Directory.CreateDirectory(@"C:/Users/Orochi/Desktop/Ticket/");
                } 
                Document documento = new Document();
                PdfWriter.GetInstance(documento, new FileStream(@"C:/Users/Orochi/Desktop/Ticket/" + S_NombrePDF + ".pdf", FileMode.OpenOrCreate));
                documento.Open();
                documento.Add(new Paragraph(S_Cadena));
                documento.Close();

            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Error en la generacion", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
