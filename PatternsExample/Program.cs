using System;
using System.Collections.Generic;
using Patterns.Behavioral.Chain_of_responsibility;
using Patterns.Behavioral.Command;
using Patterns.Behavioral.Iterator;
using Patterns.Behavioral.Mediator;
using Patterns.Behavioral.Memento;
using Patterns.Behavioral.Observer;
using Patterns.Behavioral.State;
using Patterns.Behavioral.Strategy;
using Patterns.Behavioral.Template_Method;
using Patterns.Creational;
using Patterns.Creational.Abstract_factory;
using Patterns.Creational.Builder;
using Patterns.Creational.Factory_Method;
using Patterns.Structural.Adapter;
using Patterns.Structural.Bridge;
using Patterns.Structural.Composite;
using Patterns.Structural.Decorator;
using Patterns.Structural.Facade;
using Patterns.Structural.Flyweight;
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
            FlyweightTest();
            StrategyTest();
            ChainOfResponsibilityTest();
            ObserverTest();
            CommandTest();
            MediatorTest();
            TemplateMethodTest();
            MementoTest();
            IteratorTest();
            StateTest();
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
        
        private static void FlyweightTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("FlyweightTest");
            var factory = new CharFabric();
            var aSymb = factory.GetCharForDrawing('a');
            var aSymbTwo = factory.GetCharForDrawing('a');
            var bSymb = factory.GetCharForDrawing('b');

            var context = new DrawContext();
            aSymb.DrawChar(context);
            aSymbTwo.DrawChar(context);
            bSymb.DrawChar(context);
            
            Console.WriteLine("---------------------------");
        }
        
        private static void StrategyTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("StrategyTest");
            var car = new HybridCar(new PetrolMove());
            car.Move();
            car.SetStrategy(new ElectricMove());
            car.Move();

            Console.WriteLine("---------------------------");
        }
        
        private static void ChainOfResponsibilityTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("ChainOfResponsibilityTest");
            var chain = new VisaHandler(new MaestroHandler(new MastercardHandler(null)));
            chain.Handle(new Request(){ PaymentType = PaymentType.Maestro});
            Console.WriteLine("---------------------------");
            chain.Handle(new Request(){ PaymentType = PaymentType.Visa});
            Console.WriteLine("---------------------------");
        }
        
        private static void ObserverTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("ObserverTest");
            var newsSite = new NewsSite();
            newsSite.AddNews(new NewsUnit(){Title = "1"});
            
            newsSite.AddObserver(new RssObserver());
            newsSite.AddNews(new NewsUnit(){Title = "2"});
            
            var observer = new RssObserver();
            newsSite.AddObserver(observer);
            newsSite.AddNews(new NewsUnit(){Title = "3"});
            
            newsSite.Remove(observer);
            newsSite.AddNews(new NewsUnit(){Title = "4"});
            
            Console.WriteLine("---------------------------");
        }
        
        
        private static void CommandTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("CommandTest");
            var tv = new TV();
            var command = new TVOnCommand(tv);
            var pult = new RemoteControl();
            pult.SetCommand(command);
            pult.ClickExecute();
            pult.ClickUndo();
            Console.WriteLine("---------------------------");
        }
        
        private static void MediatorTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("CommandTest");
            var mediator = new Mediator();
            var fc = new FirstColleuge(mediator);
            var sc = new SecondColleuge(mediator);


            mediator.FirstColleuge = fc;
            mediator.SecondColleuge = sc;
            
            fc.Send("Test1");
            sc.Send("Test2");
            Console.WriteLine("---------------------------");
        }
        
        private static void TemplateMethodTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("TemplateMethodTest");
            Education sc = new School();
            sc.Learn();
            Education univer = new University();
            univer.Learn();
            Console.WriteLine("---------------------------");
        } 
        
        private static void MementoTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("MementoTest");
            var hero = new GameHero();
            var caretaker = new Caretaker();
            caretaker.States.Push(hero.GetState());
            hero.Shoot();
            hero.Shoot();
            hero.AddHealth();
            caretaker.States.Push(hero.GetState());
            hero.RestoreState(caretaker.States.Pop());
            hero.RestoreState(caretaker.States.Pop());
            Console.WriteLine("---------------------------");
        }

        private static void IteratorTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("IteratorTest");
            var collection = new IntCollection();
            collection[0] = 0;
            collection[1] = 1;
            collection[2] = 2;
            collection[3] = 3;
            var iterator = collection.GetIterator();
            while (!iterator.IsDone())
            {
                
                Console.WriteLine(iterator.CurrentItem());
                iterator.Next();
            }
            
            Console.WriteLine("---------------------------");
        }
        
        private static void StateTest()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("StateTest");
            var water = new Water(new Ice());
            water.Heat();
            water.Heat();
            water.Cold();
            water.Cold();
            Console.WriteLine("---------------------------");
        } 

    }
}