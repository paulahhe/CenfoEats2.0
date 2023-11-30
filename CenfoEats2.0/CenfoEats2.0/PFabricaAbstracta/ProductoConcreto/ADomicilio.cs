using CenfoEats2._0.PFabricaAbstracta.ProductoAbstracto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PObservador;
using CenfoEats2._0.PObservador.Interfaces;
using CenfoEats2._0.PEstado.Abstracto;
using CenfoEats2._0.PEstado.Contexto;

namespace CenfoEats2._0.PFabricaAbstracta.ProductoConcreto
{
    public class ADomicilio : Pedido, ISujeto
    {

        private readonly List<IObservador> _observadores = new List<IObservador>();

        private ManejadorEstado manejadorEstado;

        public ADomicilio(IEstadoPedido estadoInicial)
        {
            this.manejadorEstado = new ManejadorEstado(estadoInicial);
        }

        public ADomicilio()
        {
            idDriver = -1;
            address = null;
        }

        public ADomicilio(int pId, string pAddress)
        {
            idDriver = pId;
            address = pAddress;
        }

        public int GetIdDriver()
        {
            return idDriver;
        }

        public string GetAddress()
        {
            return address;
        }

        public int GetPickUp()
        {
            return 1;
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
