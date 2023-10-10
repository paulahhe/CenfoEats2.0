using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2.PPrototipo.iPrototipo
{
    public abstract class Restaurant
    {
        public string name { get; set; }
        public string address { get; set; }
        public int phoneNumber { get; set; }
        public string foodType { get; set; }
        public int restaurantRating { get; set; }
        
        public string getData()
        {
            string mData = "< Sobre este producto >\n";

            mData += "Nombre del restaurante: " + name + "\n";
            mData += "Dirección: " + address + "\n";
            mData += "Número de teléfono: " + phoneNumber + "\n";
            mData += "Tipo de comida: " + foodType + "\n";
            mData += "Rating  " + restaurantRating + "\n";
           return mData;
        }

        public abstract Restaurant clone();
    }
}
