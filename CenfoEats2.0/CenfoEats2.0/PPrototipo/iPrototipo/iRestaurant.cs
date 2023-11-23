using CenfoEats2._0.ObjetosDB;
using CenfoEats2._0.PPrototipo.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PPrototipo.iPrototipo
{
    public abstract class iRestaurant
    {
        public string name { get; set; }
        public string address { get; set; }
        public int phoneNumber { get; set; }
        public string foodType { get; set; }
        public int restaurantRating { get; set; }
        public List<ProductsDB> menu { get; set; }

        //iRestaurant clone();
    }
}
