using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class AltoModel : ICarSupplier
    {
        public string GetCarEngine()
        {
            return "Alto Engine";
        }
    }
}
