using System.Collections.Generic;
using CenfoEats2._0.ObjetosDB;
using CenfoEats2._0.PPrototipo.iPrototipo;
using CenfoEats2._0.PPrototipo.Menu;

namespace CenfoEats2._0.PPrototipo.Prototipo
{
    public class Restaurant : iRestaurant
    {
        public Restaurant(string name, string address, int phoneNumber, string foodType, int restaurantRating, List<ProductsDB> menu)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.foodType = foodType;
            this.restaurantRating = restaurantRating;
            this.menu = menu;
        }

        public string GetRestaurantData()
        {
            string restaurantData = $"Nombre del restaurante: {name}\n";
            restaurantData += $"Dirección: {address}\n";
            restaurantData += $"Número de teléfono: {phoneNumber}\n";
            restaurantData += $"Tipo de comida: {foodType}\n";
            restaurantData += $"Rating: {restaurantRating}\n";

            return restaurantData;
        }

        public string GetMenuData()
        {
            string menuData = "< Menú del restaurante >\n";

            foreach (var platillo in menu)
            {
                menuData += $"Nombre: {platillo.nombre}, Precio: {platillo.precio}, Descripción: {platillo.descripcion}\n";
            }

            return menuData;
        }

        public iRestaurant clone()
        {
            return new Restaurant(name, address, phoneNumber, foodType, restaurantRating, menu);
        }
        //iRestaurant originalRestaurant = new Restaurant("Paula's", "Cartago", 123456, "Thai", 5, new List<Platillo>());
        //iRestaurant clonedRestaurant = originalRestaurant.clone();

    }
}
