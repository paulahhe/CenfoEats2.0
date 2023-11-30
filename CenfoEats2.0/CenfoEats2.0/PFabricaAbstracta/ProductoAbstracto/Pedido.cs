using CenfoEats2._0.PEstado.Abstracto;
using CenfoEats2._0.PEstado.Contexto;
using CenfoEats2._0.PPrototipo.Menu;
using CenfoEats2._0.PObservador.Interfaces;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto
{
    public abstract class Pedido : BaseEntity, IPedido
    {
        public int idOrder { get; set; }
        public int pickUp { get; set; } // 1 -> Pickup 0 -> Recoger
        public int idClient { get; set; }
        public int idRestaurant { get; set; }
        public string status { get; set; }
        public DateTime date { get; set; }
        public int idDriver { get; set; }
        public string address { get; set; }
        public Platillo platillo { get; set; }
        private ManejadorEstado manejadorEstado;
        public Pedido(int idOrder, int pickUp, int idClient, int idRestaurant, string status, DateTime date, Platillo platillo)
        {
            this.idOrder = idOrder;
            this.pickUp = pickUp;
            this.idClient = idClient;
            this.idRestaurant = idRestaurant;
            this.status = status;
            this.date = date;
            this.platillo = platillo;
        }

        // Constructor ADOMICILIOoooooooo
        public Pedido(int idOrder, int pickUp, int idClient, int idRestaurant, string status, DateTime date, int idDriver, string address, Platillo platillo)
            : this(idOrder, pickUp, idClient, idRestaurant, status, date, platillo)
        {
            this.idDriver = idDriver;
            this.address = address;
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
            // Implementa la lógica para establecer el nuevo estado
            status = nuevoEstado;
        }

        public override string ToString()
        {
            if (pickUp == 1)
            {
                return $"ID: {idOrder}, PickUp: Pickup, ID Cliente: {idClient}, " +
                       $"ID Restaurante: {idRestaurant}, Estado: {status}, Fecha: {date.ToString("yyyy-MM-dd HH:mm:ss")}, " +
                       $"ID Repartidor: {idDriver}, Dirección: {address}, Platillo:  {platillo}";
            }
            else
            {
                return $"ID: {idOrder}, PickUp: Recoger, ID Cliente: {idClient}, " +
                       $"ID Restaurante: {idRestaurant}, Estado: {status}, Fecha: {date.ToString("yyyy-MM-dd HH:mm:ss")}, Platillo: {platillo}";
            }
        }

        public void CambiarEstado(string nuevoEstado)
        {
            status = nuevoEstado;
        }
    }
}