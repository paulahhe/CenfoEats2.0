using System.Collections.Generic;
using System.Text;
using CenfoEats2._0.ObjetosDB;
using CenfoEats2._0.PPrototipo.iPrototipo;
using CenfoEats2._0.PPrototipo.Menu;

namespace CenfoEats2._0.PPrototipo.Prototipo
{
    public class Restaurant : iRestaurant
    {
        public Restaurant(string name, string address, string phoneNumber, string foodType, int restaurantRating, List<ProductsDB> menu)
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
            StringBuilder restaurantData = new StringBuilder();

            restaurantData.AppendLine($"Restaurante Creado");
            restaurantData.AppendLine($"Nombre del restaurante: {name}");
            restaurantData.AppendLine($"Dirección: {address}");
            restaurantData.AppendLine($"Número de teléfono: {phoneNumber}");
            restaurantData.AppendLine($"Tipo de comida: {foodType}");
            restaurantData.AppendLine($"Rating: {restaurantRating}");

            if (menu.Count > 0)
            {
                restaurantData.AppendLine("Platillos:");

                foreach (var platillo in menu)
                {
                    restaurantData.AppendLine($"- {platillo.nombre}, Precio: {platillo.precio}, Descripción: {platillo.descripcion}");
                }
            }
            else
            {
                restaurantData.AppendLine("No hay platillos disponibles en el menú.");
            }

            return restaurantData.ToString();
        }

        public iRestaurant clone()
        {
            return new Restaurant(name, address, phoneNumber, foodType, restaurantRating, menu);
        }
        //iRestaurant originalRestaurant = new Restaurant("Paula's", "Cartago", 123456, "Thai", 5, new List<Platillo>());
        //iRestaurant clonedRestaurant = originalRestaurant.clone();
    }
}
