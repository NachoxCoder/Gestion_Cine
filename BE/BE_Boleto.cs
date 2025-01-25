using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Boleto
    {
        public int ID { get; set; }
        public int IdCliente { get; set; }
        public int IdFuncion { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Precio { get; set; }
        public string NumeroButaca { get; set; }
    }
}
