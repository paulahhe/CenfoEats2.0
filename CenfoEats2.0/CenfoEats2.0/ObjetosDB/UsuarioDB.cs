using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0
{
    internal class UsuarioDB : BaseEntity
    {
        public string nombre { set; get; }
        public string correo_electronico { set; get; }
        public string telefono { set; get; }
        public string tipo { set; get; }    
        public string contrasenna { set; get; }
    }
}
