using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Mappers
{
    public class MapperButaca
    {
        private readonly DAL_Xml _dalXml;

        public MapperButaca()
        {
            _dalXml = new DAL_Xml();
        }

        public List<BE.BE_Butaca> Consultar()
        {
            return _dalXml.LeerXml<BE.BE_Butaca>();
        }

        public void OcuparButaca(int idButaca, int idFuncion)
        {
            var butacas = _dalXml.LeerXml<BE.BE_Butaca>();
            var butaca = butacas.First(x => x.ID == idButaca);
            butaca.Disponible = false;
            _dalXml.GuardarXml(butacas);
        }
    }
}
