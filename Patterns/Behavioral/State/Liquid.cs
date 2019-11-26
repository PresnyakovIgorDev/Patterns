using System;

namespace Patterns.Behavioral.State
{
    public class Liquid : IWaterState
    {
        public void Heat(Water context)
        {
            Console.WriteLine("Превращение воды в пар");
            context.State = new Gas();
        }

        public void Cold(Water context)
        {
            Console.WriteLine("Превращение воды в лед");
            context.State = new Ice();
        }
    }
}