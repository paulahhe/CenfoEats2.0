using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto
{
    public abstract class Pedido : BaseEntity, IPedido
    {

        public int idOrder { get; set; }
        public int pickUp { get; set; } //1 -> Pickup 0-> Recoger
        public int idClient { get; set; }
        public int idRestaurant { get; set; }
        public string status { get; set; }
        public DateTime date { get; set; }



        public Pedido(int idOrder, int pickUp, int idClient, int idRestaurant, string status, DateTime date)
        {
            this.idOrder = idOrder;
            this.pickUp = pickUp;
            this.idClient = idClient;
            this.idRestaurant = idRestaurant;
            this.status = status;
            this.date = date;
        }


        public Pedido()
        {
        }

        public int GetIdOrder()
        {
            return idOrder;
        }

        public int GetIdClient()
        {
            return idClient;
        }


        public int GetIdRestaurant()
        {
            return idRestaurant;
        }

        public string GetStatus()
        {
            return status;
        }

        public DateTime GetDate()
        {
            return date;
        }
        public int GetPickUp()
        {
            return pickUp;
        }

        public void SetStatus(string nuevoEstado)
        {
            throw new NotImplementedException();
        }
    }


}

