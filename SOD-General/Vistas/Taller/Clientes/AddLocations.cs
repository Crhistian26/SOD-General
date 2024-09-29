using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Wordprocessing;
using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using SOD_General.Vistas.Taller.Pruebadiseño;

namespace SOD_General.Vistas.Taller.Clientes
{
    using SystemDrawingFont = System.Drawing; // Alias para System.Drawing.Font
    using OpenXmlFont = DocumentFormat.OpenXml.Wordprocessing; // Alias para OpenXML.Font
    using iTextSharpText = iTextSharp.text; // Alias para iTextSharp.text
    public partial class AddLocations : Form
    {

        private void CrearYAbrirPDF()
        {
            // Ruta donde se creará el PDF en el escritorio del usuario "DEX"
            string rutaPDF = @"C:\Users\DEX\Desktop\ArchivoPrueba.pdf";

            // Crear el documento PDF con iTextSharp
            iTextSharpText.Document documento = new iTextSharpText.Document();

            try
            {
                using (FileStream fs = new FileStream(rutaPDF, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfWriter writer = PdfWriter.GetInstance(documento, fs);
                    documento.Open();

                    // Definir las fuentes utilizando iTextSharp
                    iTextSharpText.Font tituloFuente = iTextSharpText.FontFactory.GetFont(iTextSharpText.FontFactory.HELVETICA_BOLD, 18, iTextSharpText.BaseColor.BLACK);
                    iTextSharpText.Font textoFuente = iTextSharpText.FontFactory.GetFont(iTextSharpText.FontFactory.HELVETICA, 12, iTextSharpText.BaseColor.BLACK);

                    // Agregar el título
                    iTextSharpText.Paragraph titulo = new iTextSharpText.Paragraph("Documento Generado", tituloFuente);
                    titulo.Alignment = iTextSharpText.Element.ALIGN_CENTER;
                    documento.Add(titulo);

                    // Salto de línea
                    documento.Add(new iTextSharpText.Paragraph("\n"));

                    // Agregar el texto
                    iTextSharpText.Paragraph texto = new iTextSharpText.Paragraph("Prueba1 - Este es un ejemplo de generación de PDF en WinForms.", textoFuente);
                    documento.Add(texto);

                    // Cerrar el documento
                    documento.Close();
                }

                // Abrir el archivo PDF automáticamente
                AbrirPDF(rutaPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear o abrir el archivo PDF: " + ex.Message);
            }
        }

        // Método para abrir el archivo PDF
        private void AbrirPDF(string rutaArchivo)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaArchivo,
                    UseShellExecute = true // Usa el shell del sistema operativo para abrir el archivo con la aplicación predeterminada
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo PDF: " + ex.Message);
            }
        }
    




















ClientController clieControl =  new ClientController();
        public AddLocations()
        {
            InitializeComponent();
        }

        private void btn_AgregarClientes_Click(object sender, EventArgs e)
        {
            CrearYAbrirPDF();
        //   clieControl.AgregarSucursal(txtCliente.Text, txtDireccion.Text, txtNumero1.Text, txtNumero2.Text, CbRnc.SelectedItem.ToString(), CbContact.SelectedItem.ToString(), cbTipoCliente.SelectedItem.ToString());
        //    txtCliente.Text = null;
        //    txtDireccion.Text = null;
        //    txtNumero1.Text = null;
        //    txtNumero2.Text = null;
        //    CbContact.SelectedItem = null;
        //    CbRnc.SelectedItem = null;
        }

        private void btnBuscarRnc_Click(object sender, EventArgs e)
        {
            RncSearch rncSearch = new RncSearch();
            rncSearch.Show();   
        }

        private void btnBuscarCtc_Click(object sender, EventArgs e)
        {
            //if (CbRnc.SelectedItem != null)
            //{
                string rnc = CbRnc.SelectedItem.ToString();
                ContactoSearch contactoSearch = new ContactoSearch(rnc);
                contactoSearch.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Primero seleccione el numero de identificacion de la entidad");
            //}
        }



        public void cbRncRelleno()
        {
           List<Client> cliente = clieControl.ViewIdentifier();

            CbRnc.Items.Clear();
            CbRnc.SelectedItem = null;

            foreach (var client in cliente)
            {
                CbRnc.Items.Add(client._Identifier);
            }
        }

        public void cbCtcRelleno(string a)
        {
            if (CbRnc.SelectedItem != null)
            {
                string rnc = a;
                List<Contact> contact = clieControl.ContactDataSearch(rnc);

                CbContact.Items.Clear();
                CbContact.SelectedItem = null;

                foreach (var cont in contact)
                {
                    CbContact.Items.Add(cont.ContactName);
                }
            }
        }

        private void CbContact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbRnc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCtcRelleno(CbRnc.SelectedItem.ToString());
        }

        private void AddLocations_Load(object sender, EventArgs e)
        {
            cbRncRelleno();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AddContact addCont = new AddContact();
            addCont.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AddIdentifier addId = new AddIdentifier();
            addId.Show();
        }
    }
}
