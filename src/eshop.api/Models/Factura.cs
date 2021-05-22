using System;
using System.Collections.Generic;

namespace eshop.api.Models
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int ModoPagoId { get; set; }
        public ModoPago ModoPago { get; set; }
        public DateTime Fecha { get; set; }
        public List<Detalle> Detalles { get; set; }

    }
}