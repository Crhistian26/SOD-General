using System;

namespace Modelos.Taller
{
    public class Quotation
    {
        public int IdQuotation { get; set; }
        public int TecnicalId { get; set; }
        public int ReportId { get; set; }
        public DateTime DateQuotation { get; set; }
        public string Seller { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Quotation"/>.
        /// </summary>
        /// <param name="idQuotation">ID de la cotización.</param>
        /// <param name="tecnicalId">ID del técnico.</param>
        /// <param name="reportId">ID del reporte asociado.</param>
        /// <param name="dateQuotation">Fecha de la cotización.</param>
        /// <param name="seller">Nombre del vendedor.</param>
        public Quotation(int idQuotation, int tecnicalId, int reportId, DateTime dateQuotation, string seller)
        {
            IdQuotation = idQuotation;
            TecnicalId = tecnicalId;
            ReportId = reportId;
            DateQuotation = dateQuotation;
            Seller = seller;
        }
    }

}
