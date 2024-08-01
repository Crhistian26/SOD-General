namespace Modelos.Taller
{
    public class QuotationDetails
    {
        public int IdQuotationDetails { get; set; }
        public int QuotationId { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="QuotationDetails"/>.
        /// </summary>
        /// <param name="idQuotationDetails">ID de los detalles de cotización.</param>
        /// <param name="quotationId">ID de la cotización asociada.</param>
        /// <param name="item">Ítem de la cotización.</param>
        /// <param name="quantity">Cantidad del ítem.</param>
        public QuotationDetails(int idQuotationDetails, int quotationId, string item, int quantity)
        {
            IdQuotationDetails = idQuotationDetails;
            QuotationId = quotationId;
            Item = item;
            Quantity = quantity;
        }
    }

}
