using System;

namespace Patterns.Structural.Facade
{
    public class Control
    {
        public void Left()
        {
            Console.WriteLine("Поворот налево");
        }
        
        public void Right()
        {
            Console.WriteLine("Поворот направо");
        }
        
        public void Forward()
        {
            Console.WriteLine("Вперед");
        }
    }
}