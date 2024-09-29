using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using itst = iTextSharp.text;
using itstPW = iTextSharp.text.pdf.PdfWriter;

namespace SOD_General.Vistas.Taller
{
    public class Exportar
    {
        public void PdfCrear()
        {
            //ruta de creacion
            string rutaPDF = "";

            //ni idea, Creo para determinar el tamaño de la hoja
            itst.Document pdfDoc = new itst.Document(itst.PageSize.A4);
            
            //Crea la variable de escritura
            FileStream fs = null;
            
            try 
            {
                //aqui dice que se crea el PDF
                fs = new FileStream(rutaPDF, FileMode.Create, FileAccess.Write, FileShare.None);

                //inicializar el pdfWriter
                itstPW.GetInstance(pdfDoc, fs);

                //abrir el documento para escribir en el
                pdfDoc.Open();

                pdfDoc.AddTitle("OrdenDeEntrada");
                Process.Start(rutaPDF);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            finally
            {
                //asegurar que se cerro la escritura del documento para cerrar recursos
                if (pdfDoc.IsOpen())
                {
                    pdfDoc.Close();
                }
                //cerrar el FileStream si fue abierto, ni idea
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }


        }
    }
}
