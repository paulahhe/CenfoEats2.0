using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PPrototipo.iPrototipo
{
    public abstract class iPlatillo
    {
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public string descripcion { get; set; }

        public abstract iPlatillo cloneP();

    }

}
