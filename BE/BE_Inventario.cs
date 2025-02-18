using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Inventario
    {
        public int ID { get; set; }
        public BE_Inventario()
        {
            Productos = new List<BE_Producto>();
        }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public decimal PrecioUnitario { get; set; }
        public bool EstaActivo { get; set; }
        public List<BE_Producto> Productos { get; set; }
        public List<BE_OrdenCompra> OrdenesCompra { get; set; }
    }
}
