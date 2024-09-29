using DocumentFormat.OpenXml.Bibliography;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
            //    //primer codigo para comparar
            //    try
            //    {

            //        // Crear el documento PDF
            //        itst.Document documento = new itst.Document();
            //        PdfWriter.GetInstance(documento, new FileStream(rutaPDF, FileMode.Create));

            //        // Abrir el documento para agregar contenido
            //        documento.Open();

            //        // Agregar un título (opcional)
            //        documento.AddTitle("Mi Documento PDF de Ejemplo");

            //        // Agregar un párrafo de ejemplo al documento
            //        documento.Add(new Paragraph("Este es un documento PDF creado usando iTextSharp en C#."));

            //        // Cerrar el documento
            //        documento.Close();
            //        Process.Start(rutaPDF);

            //        // Confirmación
            //        MessageBox.Show("El documento PDF se ha creado y guardado en: " + rutaPDF);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }


            //segundo codigo para comparar
            //ruta de creacion
            // Obtener la ruta del escritorio
            
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Crear la carpeta "MiCarpetaPDF" en el escritorio si no existe
            string rutaCarpeta = Path.Combine(rutaEscritorio, "MiCarpetaPDF");
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            // Ruta completa del archivo PDF que se va a crear
            string dat = DateTime.Now.ToString("yyyy-MM-dd hh-mm-tt");
            string rutaPDF = Path.Combine(rutaCarpeta, $"DocumentoEjemplo_{dat}.pdf");


            //ni idea, Creo para determinar el tamaño de la hoja
            itst.Document pdfDoc = new itst.Document(itst.PageSize.A4);

            //Crea la variable de escritura
            FileStream fs = null;

            
            //aqui dice que se crea el PDF
            fs = new FileStream(rutaPDF, FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                //inicializar el pdfWriter
                itstPW.GetInstance(pdfDoc, fs);

                //abrir el documento para escribir en el
                pdfDoc.Open();

                pdfDoc.AddTitle("OrdenDeEntrada");
                pdfDoc.Add(new iTextSharp.text.Paragraph("Contenido del PDF"));

                Process.Start(rutaPDF);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "+ ex.ToString());
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
