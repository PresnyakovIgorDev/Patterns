using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Structural.Composite
{
    public class Composite : Component
    {
        private List<Component> _childrens = new List<Component>();
        
        public Composite(string name, int cost) : base(name, cost)
        {
        }

        public override void Add(Component component)
        {
            _childrens.Add(component);
        }

        public override void Remove(Component component)
        {
            _childrens.Remove(component);
        }

        public override int GetFullCost()
        {
            return Cost + _childrens.Sum(child => child.GetFullCost());
        }

        public override void Display()
        {
            Console.WriteLine("Узел "  + Name);
            Console.WriteLine("Подузлы:");
            foreach (Component component in _childrens)
            {
                component.Display();
            }
        }
    }
}