using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BE
{
    [XmlRoot("Membresia")]
    public class BE_Membresia : BE_EntidadBase
    {
        public BE_Membresia()
        {
        }
        [XmlElement("IdCliente")]
        public int IdCliente { get; set; }

        [XmlElement("FechaIncio")]
        public DateTime FechaInicio { get; set; }

        [XmlElement("FechaFin")]
        public DateTime FechaFin { get; set; }

        [XmlElement("CostoMensual")]
        public decimal CostoMensual { get; set; }

        [XmlElement("Tipo")]
        public TipoMembresia Tipo { get; set; }

        [XmlElement("EstaActiva")]
        public bool EstaActiva { get; set; }

        [XmlIgnore]
        public virtual BE_Cliente Cliente { get; set; }
    }

    public enum TipoMembresia
    {
        Plata,
        Oro,
        Premium
    }
}
