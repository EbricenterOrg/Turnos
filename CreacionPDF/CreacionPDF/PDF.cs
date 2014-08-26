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

        public void DocPDF(String Cadena)
        {
            try
            {
                Document documento = new Document();
                PdfWriter.GetInstance(documento, new FileStream("PDF.pdf",FileMode.OpenOrCreate));
                documento.Open();
                documento.Add(new Paragraph(Cadena));
                documento.Close();

            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Error en la generacion", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
