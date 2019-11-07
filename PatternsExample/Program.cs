using System;
using Patterns.Creational;

namespace PatternsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.TestProperty);
            Console.WriteLine(Singleton.Instance.TestProperty);

            Console.ReadLine();
        }
    }

}
