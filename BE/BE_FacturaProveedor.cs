using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_FacturaProveedor
    {
        public int ID { get; set; }
        public string NumeroFactura{ get; set; }
        public BE_Cliente Cliente { get; set; }
        public string TipoFactura { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public decimal IVA { get; set; }
        public DateTime FechaEmision { get; set; }
        public string MetodoPago { get; set; }
        public bool EstaPagada { get; set; }

        public BE_FacturaProveedor()
        {
        }

        public override string ToString()
        {
            return $"Factura N° {NumeroFactura} - {FechaEmision:dd/MM/yyyy} - Total: ${Total:N2}";
        }
    }
}
