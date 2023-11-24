﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenfoEats2._0.PObservador.Concreto;

namespace CenfoEats2._0.PObservador.Interfaces
{
    public interface ISujeto
    {
        void addObserver(Observador o);
        void removeObserver(Observador o);
        void notifyObservers();
    }
}
