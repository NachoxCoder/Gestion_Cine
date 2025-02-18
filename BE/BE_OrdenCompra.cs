using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_OrdenCompra
    {
        public BE_OrdenCompra()
        {
            Productos = new List<BE_Producto>();
            FechaOrdenCompra = DateTime.Now;
        }

        public int ID { get; set; }
        public DateTime FechaOrdenCompra { get; set; }
        public decimal TotalOrdenCompra { get; set; }
        public BE_Proveedor Proveedor { get; set; }
        public int CantidadProducto { get; set; }

        public List<BE_Producto> Productos { get; set; }

        public void CalcularTotal()
        {
            TotalOrdenCompra = 0;
            foreach (var producto in Productos)
            {
                TotalOrdenCompra += producto.PrecioProducto * CantidadProducto;
            }
        }
    }
}
