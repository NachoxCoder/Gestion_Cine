using System.Xml;
using System.Xml.Serialization;

namespace BE
{
    [XmlRoot("Cliente")]
    public class BE_Cliente : BE_EntidadBase
    {
        public BE_Cliente()
        {
            //Boletos = new List<BE_Boleto>();
        }
        [XmlElement("Nombre")]
        public string Nombre { get; set; }
        [XmlElement("Apellido")]
        public string Apellido { get; set; }
        [XmlElement("DNI")]
        public string DNI { get; set; }
        [XmlElement("Email")]
        public string Email { get; set; }
        [XmlElement("Telefono")]
        public string Telefono { get; set; }
        [XmlElement("Direccion")]
        public string Direccion { get; set; }
        [XmlElement("FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [XmlIgnore]
        public virtual BE_Membresia Membresia { get; set; }
        [XmlIgnore]
        public virtual ICollection<BE_Boleto> Boletos { get; set; }

        public string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public int Edad()
        {
            return DateTime.Today.Year - FechaNacimiento.Year;
        }
        
        public TipoMembresia? DevuelveMembresiaTipo()
        {
            return Membresia?.Tipo;
        }
        public bool TieneMembresia()
        {
            return Membresia != null && Membresia.EstaActiva;
        }
    }
}
