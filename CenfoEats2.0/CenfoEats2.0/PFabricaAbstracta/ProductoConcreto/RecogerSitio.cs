using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PObservador.Interfaces;
using CenfoEats2._0.PEstado.Contexto;
using CenfoEats2._0.PEstado.Concreto;
using CenfoEats2._0.PEstado.Abstracto;

namespace CenfoEats2._0.PFabricaAbstracta.ProductoConcreto
{
    public class RecogerSitio : IPedido, ISujeto
    {
        public int idOrder { get; set; }
        public int idClient { get; set; }
        public int idRestaurant { get; set; }
        public string status { get; set; }
        public DateTime date { get; set; }

        private readonly List<IObservador> _observadores = new List<IObservador>();

        private ManejadorEstado manejadorEstado;

        public RecogerSitio(IEstadoPedido estadoInicial)
        {
            this.manejadorEstado = new ManejadorEstado(estadoInicial);
        }

        public RecogerSitio()
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
            return manejadorEstado.getInfo();
        }

        public DateTime GetDate()
        {
            return date;
        }

        public int GetIdDriver()
        {
            throw new NotImplementedException();
        }
        public void SetStatus(string newStatus)
        {
                status = newStatus;
                notifyObservers();
        }
        public void CambiarEstado(IEstadoPedido nuevoEstado)
        {
            manejadorEstado.setEstadoPedido(nuevoEstado);
            notifyObservers();
        }

        public void addObserver(IObservador observador)
        {
            _observadores.Add(observador);
        }

        public void removeObserver(IObservador observador)
        {
            _observadores.Remove(observador);
        }

        public void notifyObservers()
        {
            _observadores.ForEach(observador => observador.Update(status));
        }

    }
}

