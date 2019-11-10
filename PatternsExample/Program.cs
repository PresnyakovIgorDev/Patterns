using System;
using Patterns.Creational;
using Patterns.Creational.Abstract_factory;
using Patterns.Creational.Builder;
using Patterns.Creational.Factory_Method;
using Patterns.Structural.Adapter;
using Patterns.Structural.Bridge;

namespace PatternsExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SingletonTest();
            PrototypeTest();
            AbstractFactoryTest();
            FactoryMethodTest();
            BuilderTest();
            AdapterTest();
            BridgeTest();
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

        private static void FactoryMethodTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("FactoryMethod");
            var firstFactory = new CreatorA();
            Console.WriteLine(firstFactory.FactoryMethod());

            var secondFactory = new CreatorB();
            Console.WriteLine(secondFactory.FactoryMethod());
            Console.WriteLine("---------------------------");
        }

        private static void BuilderTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("BuilderTest");
            var director = new CoffeeDirector();
            Console.WriteLine(director.Build(new StandartCoffeeBuilder()));
            Console.WriteLine(director.Build(new MilkCoffeeBuilder()));

            Console.WriteLine("---------------------------");
        }

        private static void AdapterTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("AdapterTest");
            TestClass.Execute(new Adapter(new Adaptee()));

            Console.WriteLine("---------------------------");
        }

        private static void BridgeTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("BridgeTest");
            ProgrammerBridge programmer = new FreelanceProgrammer(new CSharp());
            programmer.DoWork();
            programmer.GetSalary();

            Console.WriteLine("---------------------------");
        }
    }
}