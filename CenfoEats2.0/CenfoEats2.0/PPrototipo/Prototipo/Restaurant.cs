using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PPrototipo.iPrototipo;
using CenfoEats2._0.PPrototipo.Menu;




namespace CenfoEats2._0.PPrototipo.Prototipo
{
    public class Restaurant : iRestaurant
    {

        public Restaurant(string name, string address, int phoneNumber, string foodType, int restaurantRating, List<Platillo> menu) : base(name, address, phoneNumber, foodType, restaurantRating, menu)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.foodType = foodType;
            this.restaurantRating = restaurantRating;
            this.menu = menu;
        }

        public override iRestaurant clone()
        {
            return new Restaurant(this.name, this.address, this.phoneNumber, this.foodType, this.restaurantRating, this.menu);
        }
    }

}