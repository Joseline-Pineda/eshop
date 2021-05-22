namespace eshop.api.Models
{
    public class Detalle
    {
        public int DetalleId { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

    }
}