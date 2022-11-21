using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class SwiftModel : ICarSupplier
    {
        public string GetCarEngine()
        {
            return "Swift Engine";
        }
    }
}
