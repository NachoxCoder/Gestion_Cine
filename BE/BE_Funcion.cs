﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BE
{
    public class BE_Funcion
    {
        public BE_Funcion() 
        { 
            Boletos = new List<BE_Boleto>();
            EstaActiva = true;
        }

        public int ID { get; set; }
        public int IdPelicula { get; set; }
        public DateTime FechaFuncion { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int IdSala { get; set; }
        public bool EstaActiva { get; set; }
        public decimal Precio { get; set; }
        public virtual BE_Pelicula Pelicula { get; set; }
        public virtual BE_Sala Sala { get; set; }
        public List<BE_Boleto> Boletos { get; set; }

        public string PeliculaTitulo ()
        {
            return Pelicula?.Titulo?? "No hay pelicula asignada";
        }
        public string SalaNombre()
        {
            return Sala?.Nombre ?? "No hay sala asignada";
        }
        public int AsientosDisponibles()
        {
            int totalCapacidadSala = Sala?.Capacidad?? 0;
            int boletosVendidos = Boletos?.Count?? 0;
            return totalCapacidadSala - boletosVendidos;
        }
    }
}
