using System;

namespace Patterns.Structural.Proxy
{
    public class RealObject : Subject
    {
        public override void Execute()
        {
            Console.WriteLine("Выполнение");
        }
    }
}