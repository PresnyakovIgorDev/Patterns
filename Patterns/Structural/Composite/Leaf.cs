using System;

namespace Patterns.Structural.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name, int cost) : base(name, cost)
        {
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public override int GetFullCost()
        {
            return Cost;
        }

        public override void Display()
        {
            Console.WriteLine("Узел "  + Name);
        }
    }
}