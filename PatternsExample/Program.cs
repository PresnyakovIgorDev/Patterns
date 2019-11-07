using System;
using Patterns.Creational;
using Patterns.Creational.Abstract_factory;

namespace PatternsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonTest();
            PrototypeTest();
            AbstractFactoryTest();
            Console.ReadLine();
        }

        private static void PrototypeTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Prototype");

            var prototype = new ConcretePrototype("1");
            var prototypeClone = prototype.Clone();
            Console.WriteLine(prototype);
            Console.WriteLine(prototypeClone);

            prototypeClone.Id = "2";

            Console.WriteLine(prototype);
            Console.WriteLine(prototypeClone);
            Console.WriteLine("---------------------------");

        }

        private static void SingletonTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Singleton");
            Console.WriteLine(Singleton.Instance.TestProperty);
            Singleton.Instance.TestProperty = "NewValue";
            Console.WriteLine(Singleton.Instance.TestProperty);
            Console.WriteLine("---------------------------");
        }

        private static void AbstractFactoryTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("AbstractFactory");
            var firstFactory = new FirstFactory();
            Console.WriteLine(firstFactory.GetAObject());
            Console.WriteLine(firstFactory.GetBObject());

            var secondFactory = new SecondFactory();
            Console.WriteLine(secondFactory.GetAObject());
            Console.WriteLine(secondFactory.GetBObject());
            Console.WriteLine("---------------------------");
        }
    }

}
