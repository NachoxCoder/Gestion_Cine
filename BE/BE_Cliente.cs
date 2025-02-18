using System.Xml;
using System.Xml.Serialization;

namespace BE
{
    public class BE_Cliente
    {
        public BE_Cliente()
        {
            Boletos = new List<BE_Boleto>();
            Membresia = null;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public BE_Membresia Membresia { get; set; }
        public List<BE_Boleto> Boletos { get; set; }
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
