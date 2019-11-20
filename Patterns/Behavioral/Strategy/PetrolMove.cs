using System;

namespace Patterns.Behavioral.Strategy
{
    public class PetrolMove : IMovableStrategy
    {
        public void Move()
        {
            Console.WriteLine("Движение на бензине");
        }
    }
}