using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using BE;

namespace BLL
{
    public class BLL_Butaca
    {
        private readonly MapperButaca _mapperButaca;

        public BLL_Butaca()
        {
            _mapperButaca = new MapperButaca();
        }

        public List<BE_Butaca> Consultar()
        {
            return _mapperButaca.Consultar();
        }

        public List<BE_Butaca> ConsultarButacasDisponibles(int idSala)
        {
            return _mapperButaca.Consultar().Where(x => x.IdSala == idSala && x.Disponible).ToList();
        }

        public void OcuparButaca(BE_Butaca butaca, BE_Funcion funcion)
        {
            _mapperButaca.OcuparButaca(butaca.ID, funcion.ID);
        }
    }
}
