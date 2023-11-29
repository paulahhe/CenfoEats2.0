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
    public class RecogerSitio : Pedido, ISujeto
    {

        private readonly List<IObservador> _observadores = new List<IObservador>();

        private ManejadorEstado manejadorEstado;

        public RecogerSitio(IEstadoPedido estadoInicial)
        {
            this.manejadorEstado = new ManejadorEstado(estadoInicial);
        }

        public RecogerSitio()
        {
           
        }

        public int GetPickUp()
        {
            return 0;
        }
        public void SetStatus(string nuevoEstado)
        {
                status = nuevoEstado;
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

