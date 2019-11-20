using System;

namespace Patterns.Behavioral.Strategy
{
    public class ElectricMove : IMovableStrategy
    {
        public void Move()
        {
            Console.WriteLine("Движение на электричестве");
        }
    }
}