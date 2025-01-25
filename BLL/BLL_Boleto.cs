using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using BE;

namespace BLL
{
    public class BLL_Boleto
    {
        private readonly MapperBoleto _mapperBoleto;

        public BLL_Boleto()
        {
            _mapperBoleto = new MapperBoleto();
        }

        public bool Alta(BE_Boleto boleto)
        {
            try
            {
                if(boleto.ID == 0)
                {
                    _mapperBoleto.Alta(boleto);
                }
                else
                {
                    _mapperBoleto.Modificar(boleto);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
