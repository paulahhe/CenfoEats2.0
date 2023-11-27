using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.ObjetosDB
{
    public class OrderDB : BaseEntity
    {

        //public int idOrder { get; set; }
        public int pickUp { get; set; } //1 -> Pickup 0-> Recoger
        public int idClient { get; set; }
        public int idRestaurant { get; set; }
        public string status { get; set; }
        public DateTime date { get; set; }

        public int idDriver { get; set; }

        public string address { get; set; }


    }
}
