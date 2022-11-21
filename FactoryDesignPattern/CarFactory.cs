using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    static class CarFactory
    {
        public static ICarSupplier GetCarInstance(Type T)
        {
            if (T.Equals(typeof(SwiftModel))) {
                return new SwiftModel();
            }
            else if (T.Equals(typeof(DzireModel)))
            {
                return new DzireModel();
            }
            else if (T.Equals(typeof(CelerioModel)))
            {
                return new CelerioModel();
            }
            else if (T.Equals(typeof(AltoModel)))
            {
                return new AltoModel();
            }
            else
            {
                return null;
            }
        }
    }
}
