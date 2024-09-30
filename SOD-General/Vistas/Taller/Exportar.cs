using DocumentFormat.OpenXml.Bibliography;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SOD_General.Controladores;
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
        EntryOrderController eoc = new EntryOrderController();
        public void PdfCrear(int id)
        {
            List<EntryOrderController.DataExport> EDE = new List<EntryOrderController.DataExport>();
            EDE = eoc.exportacion(id);

            List<EntryOrderController.DataExport> listaDE = new List<EntryOrderController.DataExport>();
            listaDE = eoc.exportacion(id);
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
                itstPW writer = PdfWriter.GetInstance(pdfDoc, fs);

               
                

                //abrir el documento para escribir en el
                pdfDoc.Open();

                ///Seccion para la imagen del logo
                string rutaImagen = "C:\\Users\\DEX\\Documents\\GitHub\\SOD-General\\SOD-General\\SOD-General\\SOD-General\\Resources\\sod.png"; // Cambia esta ruta a la ubicación de tu imagen
                                                                                                                                                                // Cargar la imagen
                    Image imagen = Image.GetInstance(rutaImagen);

                    // Establecer el tamaño deseado
                    float width = 100;  // ancho en puntos
                    float height = 100; // alto en puntos

                    // Escalar la imagen (opcional, pero se recomienda para mantener proporciones)
                    imagen.ScaleToFit(width, height);

                    // Establecer la posición de la imagen
                    imagen.SetAbsolutePosition(30, pdfDoc.PageSize.Height - 50 - 30); // 10 puntos de margen desde la parte superior

                    // Agregar la imagen al documento PDF
                    pdfDoc.Add(imagen);
                
                ///Seccion para el titulo de la empresa
                    Font fontNegrita = FontFactory.GetFont("Arial", 14, Font.BOLD, BaseColor.BLACK);

                    // 3. Crear el texto a insertar al lado de la imagen
                    Paragraph texto = new Paragraph("SOLUCIONES DE OFICINA DIAZ, SRL", fontNegrita);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    texto.IndentationLeft = 160;
                    texto.SpacingBefore =-5;  // Margen superior si se necesita más espacio
                    texto.SpacingAfter = 1;   // Margen inferior

                    // 5. Agregar el texto al documento
                    pdfDoc.Add(texto);

                ///Seccion para subtitulos
                    Font fontSub = FontFactory.GetFont("Arial", 11, Font.NORMAL, BaseColor.BLACK);

                    // 3. Crear el texto a insertar al lado de la imagen
                    Paragraph textSub = new Paragraph("Ventas y servicios de equipos de oficina", fontSub);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textSub.IndentationLeft = 185;
                    textSub.SpacingBefore = -2;  // Margen superior si se necesita más espacio
                    textSub.SpacingAfter = 1;   // Margen inferior

                    pdfDoc.Add(textSub);

                ///Seccion para subtitulos 2
                    Font fontSub2 = FontFactory.GetFont("Arial", 11, Font.NORMAL, BaseColor.BLACK);

                    // 3. Crear el texto a insertar al lado de la imagen
                    Paragraph textSub2 = new Paragraph("RNC 101-86849-1", fontSub);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textSub2.IndentationLeft = 240;
                    textSub2.SpacingBefore = 0;  // Margen superior si se necesita más espacio
                    textSub2.SpacingAfter = 1;   // Margen inferior


                ///Seccion para subtitulos 3
                    Font fontSub3 = FontFactory.GetFont("Arial", 18, Font.BOLD, BaseColor.RED);

                    // 3. Crear el texto a insertar al lado de la imagen
                    Paragraph textSub3 = new Paragraph("ORDEN DE ENTRADA", fontSub3);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textSub3.IndentationLeft = 185;
                    textSub3.SpacingBefore = 5;  // Margen superior si se necesita más espacio
                    textSub3.SpacingAfter = 1;   // Margen inferior

                    pdfDoc.Add(textSub3);

                ///Seccion para titulo datos 1
                    Font fontSub4 = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);

                    // 3. Crear el texto a insertar al lado de la imagen
                    Paragraph textSub4 = new Paragraph("Cliente: ", fontSub4);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textSub4.IndentationLeft = 0;
                    textSub4.SpacingBefore = 20;  // Margen superior si se necesita más espacio
                    textSub4.SpacingAfter = 1;   // Margen inferior

                    pdfDoc.Add(textSub4);


                ///Seccion para titulo datos 1
                Font fontTit = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);

                    // 3. Crear el texto a insertar al lado de la imagen
                    Paragraph textTit = new Paragraph("Direccion: ", fontTit);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textTit.IndentationLeft = 0;
                    textTit.SpacingBefore = 15;  // Margen superior si se necesita más espacio
                    textTit.SpacingAfter = 1;   // Margen inferior

                    pdfDoc.Add(textTit);


                    pdfDoc.AddTitle("OrdenDeEntrada");
                    // pdfDoc.Add(new iTextSharp.text.Paragraph("Contenido del PDF"));


                ///Seccion para titulo datos 2
                    Font fontTit1 = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);

                    // 3. Crear el texto a insertar al lado de la imagen
                    Paragraph textTit1 = new Paragraph("Telefono #1: ", fontTit1);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textTit1.IndentationLeft = 0;
                    textTit1.SpacingBefore = 15;  // Margen superior si se necesita más espacio
                    textTit1.SpacingAfter = 0;   // Margen inferior

                    pdfDoc.Add(textTit1);


                    pdfDoc.AddTitle("OrdenDeEntrada");
                    // pdfDoc.Add(new iTextSharp.text.Paragraph("Contenido del PDF"));



                ///Seccion para titulo datos 3
                    Font fontTit2 = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);

                    // 3. Crear el texto a insertar al lado de la imagen
                    Paragraph textTit2 = new Paragraph("# de orden: ", fontTit2);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textTit2.IndentationLeft = 350;
                    textTit2.SpacingBefore = -88;  // Margen superior si se necesita más espacio
                    textTit2.SpacingAfter = 0;   // Margen inferior

                    pdfDoc.Add(textTit2);


                ///Seccion para titulo datos 4
                    Font fontTit3 = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);

                    // 3. Crear el texto a insertar al lado de la imagen
                    Paragraph textTit3 = new Paragraph("Fecha: ", fontTit3);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textTit3.IndentationLeft = 350;
                    textTit3.SpacingBefore = 18;  // Margen superior si se necesita más espacio
                    textTit3.SpacingAfter = 0;   // Margen inferior

                    pdfDoc.Add(textTit3);

                ///Seccion agregar datos
                    Font fontTit4 = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);


                // 3. Crear el texto a insertar al lado de la imagen
                string name = listaDE.Select(e => e.cliente).First().ToString();
                Paragraph textTit4 = new Paragraph(name, fontTit4);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textTit4.IndentationLeft = 45;
                    textTit4.SpacingBefore = -52;  // Margen superior si se necesita más espacio
                    textTit4.SpacingAfter = 1;   // Margen inferior

                    pdfDoc.Add(textTit4);


                ///Seccion agregar datos
                    Font fontTit5 = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);

                    // 3. Crear el texto a insertar al lado de la imagen
                    string address = listaDE.Select(a => a.direccion).First().ToString();
                    Paragraph textTit5 = new Paragraph(address, fontTit5);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textTit5.IndentationLeft = 57;
                    textTit5.SpacingBefore = 14;  // Margen superior si se necesita más espacio
                    textTit5.SpacingAfter = 1;   // Margen inferior

                    pdfDoc.Add(textTit5);

                ///Seccion agregar datos
                    Font fontTit6 = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);

                // 3. Crear el texto a insertar al lado de la imagen
                    string Phone1 = listaDE.Select(a => a.phone1).First().ToString();
                    Paragraph textTit6 = new Paragraph(Phone1, fontTit6);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textTit6.IndentationLeft = 70;
                    textTit6.SpacingBefore = 17;  // Margen superior si se necesita más espacio
                    textTit6.SpacingAfter = 1;   // Margen inferior

                    pdfDoc.Add(textTit6);

                ///Seccion agregar datos
                    Font fontTit7 = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);

                // 3. Crear el texto a insertar al lado de la imagen
                    string Orden = listaDE.Select(a => a.idPeti).First().ToString();
                    Paragraph textTit7 = new Paragraph(Orden, fontTit7);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textTit7.IndentationLeft = 420;
                    textTit7.SpacingBefore = -90;  // Margen superior si se necesita más espacio
                    textTit7.SpacingAfter = 0;   // Margen inferior

                pdfDoc.Add(textTit7);


                ///Seccion agregar datos
                    Font fontTit8 = FontFactory.GetFont("Arial", 11, Font.NORMAL, BaseColor.BLACK);

                // 3. Crear el texto a insertar al lado de la imagen
                    string Date = listaDE.Select(a => a.Date).First().ToString();
                    Paragraph textTit8 = new Paragraph(Date, fontTit8);

                    // 4. Añadir margen al texto (margen derecho de la imagen)
                    // Añadir un margen de 120 puntos a la izquierda para que el texto no se superponga con la imagen
                    textTit8.IndentationLeft = 390;
                    textTit8.SpacingBefore = 20;  // Margen superior si se necesita más espacio
                    textTit8.SpacingAfter = 0;   // Margen inferior

                    pdfDoc.Add(textTit8);

                // Crear la tabla con 4 columnas
                PdfPTable tb = new PdfPTable(4);

                // Porcentajes para cada columna (la suma debe ser 100%)
                float[] columnWidths = new float[] { 15f, 15f, 15f, 55f };
                tb.SetWidths(columnWidths);

                // Crear y configurar las celdas
                PdfPCell clNombre = new PdfPCell(new Phrase("Marca", fontNegrita));
                clNombre.BorderWidth = 1;
                clNombre.BorderWidthBottom = 1;

                PdfPCell clModelo = new PdfPCell(new Phrase("Modelo", fontNegrita));
                clModelo.BorderWidth = 1;
                clModelo.BorderWidthBottom = 1;

                PdfPCell clSerie = new PdfPCell(new Phrase("Serie", fontNegrita));
                clSerie.BorderWidth = 1;
                clSerie.BorderWidthBottom = 1;

                PdfPCell clFallo = new PdfPCell(new Phrase("Fallo", fontNegrita));
                clFallo.BorderWidth = 1;
                clFallo.BorderWidthBottom = 1;

                // Agregar las celdas a la tabla
                tb.AddCell(clNombre);
                tb.AddCell(clModelo);
                tb.AddCell(clSerie);
                tb.AddCell(clFallo);

                foreach (var registro in listaDE)
                {
                    clNombre = new PdfPCell(new Phrase(registro.marca, fontTit8));
                    clNombre.BorderWidth = 1;

                    clModelo = new PdfPCell(new Phrase(registro.model, fontTit8));
                    clModelo.BorderWidth = 1;

                    clSerie = new PdfPCell(new Phrase(registro.serial,fontTit8));
                    clSerie.BorderWidth = 1;

                    clFallo = new PdfPCell(new Phrase("registro.fallaadsssssssssssadssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdsdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd", fontTit8));
                    clFallo.BorderWidth = 1;

                    tb.AddCell(clNombre);
                    tb.AddCell(clModelo);
                    tb.AddCell(clSerie);
                    tb.AddCell(clFallo);
                }

                // Establecer el ancho total de la tabla
                tb.TotalWidth = 525f; // Ajusta el ancho según sea necesario
                tb.PaddingTop = 600;
                // Obtener el PdfContentByte del PdfWriter
                PdfContentByte canvas = writer.DirectContent;

                // Definir la posición absoluta de la tabla (por ejemplo, 100 puntos desde la izquierda y 600 desde la parte inferior)
                float posX = 25f;
                float posY = 600f;

//Crear la tabla para los accesorios
                PdfPTable tbAccesorios = new PdfPTable(2);
                float[] column = new float[5] { 20f,20f,20f,20f,20f };

                tbAccesorios.SetWidths(column);

                foreach (var list in listaDE)
                {
                    string serial = list.serial.ToString();

                    PdfPCell clSerial = new PdfPCell(new Phrase($"{serial}", fontNegrita));
                    clSerial.BorderWidth = 1;
                    clSerial.BorderWidth = 1;

                    tbAccesorios.AddCell(clSerial);

                    clSerial = new PdfPCell(new Phrase(list.accesories.ToString(), fontTit8));
                    tbAccesorios.AddCell(clSerial);
                }

                tbAccesorios.TotalWidth = 525f; // Ajusta el ancho según sea necesario
                PdfContentByte canvas2 = writer.DirectContent;

                // Definir la posición absoluta de la tabla (por ejemplo, 100 puntos desde la izquierda y 600 desde la parte inferior)
                float posX2 = 25f;
                float posY2 = 600f;

                pdfDoc.Add(tb);
                pdfDoc.Add(tbAccesorios);
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
