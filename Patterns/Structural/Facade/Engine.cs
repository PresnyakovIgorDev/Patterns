using System;

namespace Patterns.Structural.Facade
{
    public class Engine
    {
        public void StartEngine()
        {
            Console.WriteLine("Запуск двигателя");
        }
        
        public void StopEngine()
        {
            Console.WriteLine("Стоп двигателя");
        }
    }
}