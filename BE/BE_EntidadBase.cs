using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BE
{
    [XmlInclude(typeof(BE_Cliente))]
    public abstract class BE_EntidadBase
    {
        public int ID { get; set; }
    }
}
