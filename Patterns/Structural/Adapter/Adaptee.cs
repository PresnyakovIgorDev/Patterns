using System;

namespace Patterns.Structural.Adapter
{
    public class Adaptee
    {
        public void Execute()
        {
            Console.WriteLine("Adaptee");
        }
    }
}