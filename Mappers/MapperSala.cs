using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace Mappers
{
    public class MapperSala
    {
        private readonly DAL_Xml _dalXml;

        public MapperSala()
        {
            _dalXml = new DAL_Xml();
        }

        public List<BE_Sala> Consultar()
        {
            return _dalXml.LeerXml<BE_Sala>();
        }

        public void Alta(BE_Sala sala)
        {
            List<BE_Sala> salas = _dalXml.LeerXml<BE_Sala>();
            if (salas.Any(s => s.Nombre.Equals(sala.Nombre, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Ya existe una sala con ese nombre");
            }
            sala.ID = salas.Any() ? salas.Max(x => x.ID) + 1 : 1;
            salas.Add(sala);
            _dalXml.GuardarXml(salas);
        }

        public void Baja(BE_Sala sala)
        {
            List<BE_Sala> salas = _dalXml.LeerXml<BE_Sala>();
            var salaEncontrada = salas.Find(x => x.ID == sala.ID);
            if (salaEncontrada != null)
            {
                salas.Remove(salaEncontrada);
                _dalXml.GuardarXml(salas);
            }
        }

        public void Modificar(BE_Sala sala)
        {
            List<BE_Sala> salas = _dalXml.LeerXml<BE_Sala>();
            var salaExistente = salas.Find(x => x.ID == sala.ID);
            if (salaExistente != null)
            {
                var salaConMismoNombre = salas.FirstOrDefault(s => s.ID != sala.ID && 
                                         s.Nombre.Equals(sala.Nombre,StringComparison.OrdinalIgnoreCase));

                if(salaConMismoNombre != null)
                {
                    throw new Exception("Ya existe una sala con ese nombre");
                }

                salaExistente.Nombre = sala.Nombre;
                salaExistente.Capacidad = sala.Capacidad;
                salaExistente.Tiene3D = sala.Tiene3D;
                _dalXml.GuardarXml(salas);
            }
        }

        public BE_Sala ObtenerPorNombre(string nombre)
        {
            return Consultar().FirstOrDefault(x => x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
    }
}
