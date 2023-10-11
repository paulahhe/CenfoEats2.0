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
        public string name { get; set; }
        public string address { get; set; }
        public int phoneNumber { get; set; }
        public string foodType { get; set; }
        public int restaurantRating { get; set; }
        public List<Platillo> menu { get; set; }

        public Restaurant(string name, string address, int phoneNumber, string foodType, int restaurantRating, List<Platillo> menu)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.foodType = foodType;
            this.restaurantRating = restaurantRating;
            this.menu = menu;
        }
        public iRestaurant clone()
        {
            return new Restaurant(name, address, phoneNumber, foodType, restaurantRating, menu);
        }
        //iRestaurant originalRestaurant = new Restaurant("Paula's", "Cartago", 123456, "Thai", 5, new List<Platillo>());
        //iRestaurant clonedRestaurant = originalRestaurant.clone();

    }

}
