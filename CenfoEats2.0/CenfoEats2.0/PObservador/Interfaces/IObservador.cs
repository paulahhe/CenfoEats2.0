﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PObservador.Interfaces
{
    public interface IObservador
    {
        void Update(object value, string status);
    }
}
