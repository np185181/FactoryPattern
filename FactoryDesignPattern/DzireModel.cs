using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class DzireModel : ICarSupplier
    {
        public string GetCarEngine()
        {
            return "Dzire Engine";
        }
    }
}
