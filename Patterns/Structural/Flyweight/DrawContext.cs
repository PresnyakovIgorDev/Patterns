using System;

namespace Patterns.Structural.Flyweight
{
    public class DrawContext
    {
        public void Draw(string drawInfo)
        {
            Console.WriteLine($"Отрисовка {drawInfo}");
        }
    }
}