using System;

namespace Patterns.Structural.Facade
{
    public class Transmission
    {
        public void Neutral()
        {
            Console.WriteLine("Сброс коробки в нейтраль");
        }
        
        public void Forward()
        {
            Console.WriteLine("Первая передача");
        }
    }
}