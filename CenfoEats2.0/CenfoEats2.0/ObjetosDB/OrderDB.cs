using System;
namespace CenfoEats2._0.ObjetosDB
{
    public class OrderDB : BaseEntity
    {

        public int pickUp { get; set; } //1 -> Pickup 0-> Recoger
        public int idClient { get; set; }
        public int idRestaurant { get; set; }
        public string status { get; set; }
        public DateTime date { get; set; }

        public int idDriver { get; set; }

        public string address { get; set; }


        //public override string ToString()
        //{
        //    return nombre;
        //}

    }
}
