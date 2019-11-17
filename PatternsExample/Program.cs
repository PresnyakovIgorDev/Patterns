using System;
using Patterns.Creational;
using Patterns.Creational.Abstract_factory;
using Patterns.Creational.Builder;
using Patterns.Creational.Factory_Method;
using Patterns.Structural.Adapter;
using Patterns.Structural.Bridge;
using Patterns.Structural.Composite;
using Patterns.Structural.Decorator;
using Patterns.Structural.Facade;
using Patterns.Structural.Proxy;

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
            CompositeTest();
            FacadeTest();
            ProxyTest();
            DecoratorTest();
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
        
        private static void CompositeTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("CompositeTest");
            Component box = new Composite("Коробка",1);
            box.Add(new Leaf("Книга",50));
            var subBox = new Composite("Контейнер", 2);
            subBox.Add(new Leaf("Видеокарта", 100));
            subBox.Add(new Leaf("CPU", 150));

            box.Add(subBox);
            box.Display();
            Console.WriteLine(box.GetFullCost());
            Console.WriteLine("---------------------------");
        }
        
        private static void FacadeTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("FacadeTest");
            var facade = new CarFacade(new Engine(), new Transmission(), new Control());
            facade.Start();
            facade.MoveToHome();
            facade.Stop();

            Console.WriteLine("---------------------------");
        }
        
        private static void ProxyTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("ProxyTest");
            var proxy = new ProxyObject(new RealObject());
            proxy.Execute();

            Console.WriteLine("---------------------------");
        }
        
        private static void DecoratorTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("DecoratorTest");
            var decorator = new CheesePizza(new RussianPizza());
            Console.WriteLine(decorator.Title);
            Console.WriteLine(decorator.GetCost());

            Console.WriteLine("---------------------------");
        }
    }
}