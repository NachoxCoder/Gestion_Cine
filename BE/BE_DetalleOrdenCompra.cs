using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_DetalleOrdenCompra
    {
        public int ID { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal 
        {
            get
            {
                return Cantidad * PrecioUnitario;
            }
        }
        public BE_Producto Producto { get; set; }
        public BE_OrdenCompra OrdenCompra { get; set; }

        public BE_DetalleOrdenCompra()
        {
            Producto = new BE_Producto();
            OrdenCompra = new BE_OrdenCompra();
        }

    }
}
