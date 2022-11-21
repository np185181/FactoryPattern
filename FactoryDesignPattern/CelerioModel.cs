using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class CelerioModel : ICarSupplier
    {
        public string GetCarEngine()
        {
            return "Celerio Engine";
        }
    }
}
