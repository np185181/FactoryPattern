using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarSupplier objCarSupplier = CarFactory.GetCarInstance(typeof(CelerioModel));

            Console.WriteLine("Model Engine is " + objCarSupplier.GetCarEngine());

            Console.ReadLine();
        }
    }
}
