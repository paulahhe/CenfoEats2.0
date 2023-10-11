using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PFabricaAbstracta.ProductoConcreto
{
    public class ADomicilio : IPedido
    {
        private int idOrder;
        private int idClient;
        private int idDriver;
        private int idRestaurant;
        private string status;
        private DateTime date;


        public ADomicilio()
        {
        }

        public int IdOrder
        {
            get { return idOrder; }
            set { idOrder = 1; }
        }

        public int IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }

        public int IdDriver
        {
            get { return idDriver; }
            set { idDriver = value; }
        }


        public int IdRestaurant
        {
            get { return idRestaurant; }
            set { idRestaurant = value; }
        }

        public string Status
        {
            get { return "Pediente"; }

        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


        public int GetIdOrder()
        {
            return IdOrder;
        }

        public int GetIdClient()
        {
            return IdClient;
        }

        public int GetIdDriver()
        {
            return IdDriver;
        }

        public int GetIdRestaurant()
        {
            return IdRestaurant;
        }

        public string GetStatus()
        {
            return Status;
        }

        public DateTime GetDate()
        {
            return Date;
        }


    }
}
