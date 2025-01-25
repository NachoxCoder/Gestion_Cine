using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BE
{
    public class BE_Pelicula
    {
        public BE_Pelicula()
        {
            Funciones = new List<BE_Funcion>();
            EstaActiva = true;
        }
        //Propiedades de la clase
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public int Duracion { get; set; }
        public string Rating { get; set; }
        public bool EstaActiva { get; set; }
        public List<BE_Funcion> Funciones { get; set; }

        public string GetFuncionesDisponibles()
        {
            return Funciones?.Count(f => f.EstaActiva && f.AsientosDisponibles() > 0).ToString() ?? "0";
        }
    }
}
