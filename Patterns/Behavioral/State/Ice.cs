using System;

namespace Patterns.Behavioral.State
{
    public class Ice : IWaterState
    {
        public void Heat(Water context)
        {
            Console.WriteLine("Превращение льда в воду");
            context.State = new Liquid();
        }

        public void Cold(Water context)
        {
        }
    }
}