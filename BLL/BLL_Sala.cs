using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using BE;

namespace BLL
{
    public class BLL_Sala
    {
        private readonly MapperSala _mapperSala;

        public BLL_Sala()
        {
            _mapperSala = new MapperSala();
        }

        public void Alta(BE_Sala sala)
        {
            ValidarSala(sala);
            _mapperSala.Alta(sala);
        }

        public bool Baja(BE_Sala sala)
        {
            var salaExistente = _mapperSala.Consultar().Find(x => x.ID == sala.ID);
            if (salaExistente == null)
            {
                return false;
            }

            if(salaExistente.Funciones?.Any() == true)
            {
                throw new Exception("No se puede eliminar la sala porque tiene funciones asignadas");
            }

            _mapperSala.Baja(sala);
            return true;
        }

        public bool Modificar(BE_Sala sala)
        {
            var salaExistente = _mapperSala.ObtenerPorNombre(sala.Nombre);
            if (salaExistente == null)
            {
                return false;
            }

            ValidarSala(sala);
            _mapperSala.Modificar(sala);
            return true;
        }

        public List<BE_Sala> Consultar()
        {
            return _mapperSala.Consultar();
        }

        private void ValidarSala(BE_Sala sala)
        {
            if(string.IsNullOrWhiteSpace(sala.Nombre))
            {
                throw new Exception("El nombre de la sala es obligatorio");
            }

            if (sala.Capacidad <= 0)
            {
                throw new Exception("La capacidad de la sala debe ser mayor a 0");
            }

            var salaExistente = _mapperSala.ObtenerPorNombre(sala.Nombre);
            if (salaExistente != null && salaExistente.ID != sala.ID)
            {
                throw new Exception("Ya existe una sala con ese nombre");
            }
        }
    }
}
