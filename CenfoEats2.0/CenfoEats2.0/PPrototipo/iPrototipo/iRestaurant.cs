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
        public List<Platillo> menu { get; set; } //

        //public iRestaurant(string name, string address, int phoneNumber, string foodType, int restaurantRating, List<Platillo> menu)
        //{
        //    this.name = name;
        //    this.address = address;
        //    this.phoneNumber = phoneNumber;
        //    this.foodType = foodType;
        //    this.restaurantRating = restaurantRating;
        //    this.menu = menu;
        //}

        //public string getData()
        //{
        //    string mData = "< Sobre este producto >\n";

        //    mData += "Nombre del restaurante: " + name + "\n";
        //    mData += "Dirección: " + address + "\n";
        //    mData += "Número de teléfono: " + phoneNumber + "\n";
        //    mData += "Tipo de comida: " + foodType + "\n";
        //    mData += "Rating  " + restaurantRating + "\n";
        //    return mData;
        //}

        public abstract iRestaurant clone();

    }
}
