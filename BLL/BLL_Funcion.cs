using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using BE;

namespace BLL
{
    public class BLL_Funcion
    {
        private readonly MapperFuncion _mapperFuncion;

        public BLL_Funcion()
        {
            _mapperFuncion = new MapperFuncion();
        }

        public bool Alta(BE_Funcion funcion)
        {
            try
            {
                _mapperFuncion.Alta(funcion);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Baja(BE_Funcion funcion)
        {
            try
            {
                _mapperFuncion.Baja(funcion);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<BE_Funcion> Consultar()
        {
            return _mapperFuncion.Consultar();
        }

        public List<BE_Funcion> ConsultarFuncionesPorPelicula(int idPelicula)
        {
            return _mapperFuncion.Consultar().Where(x => x.IdPelicula == idPelicula).ToList();
        }

        public List<BE_Funcion> ConsultarFuncionesDisponibles(int idSala)
        {
            return _mapperFuncion.Consultar().Where(x => x.FechaFuncion >= DateTime.Today && x.EstaActiva)
                .OrderBy(x => x.FechaFuncion).ThenBy(x => x.HoraInicio).ToList();
        }

        public bool ValidarDisponibilidad(BE_Funcion funcion, string numeroButaca)
        {
            return _mapperFuncion.ValidarDisponibilidadButaca(funcion.ID, numeroButaca);
        }

        public bool ValidarHorarios(BE_Funcion funcion)
        {
            var funciones = _mapperFuncion.Consultar().Where(x => x.IdSala == funcion.IdSala && 
                x.FechaFuncion.Date == funcion.FechaFuncion.Date && x.ID != funcion.ID && x.EstaActiva).ToList();

            return !funciones.Any(x => (funcion.HoraInicio >= x.HoraInicio && funcion.HoraInicio < x.HoraFin) ||
                (funcion.HoraFin >= x.HoraInicio && funcion.HoraFin <= x.HoraFin));
        }
    }
}
