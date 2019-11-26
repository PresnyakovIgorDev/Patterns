using System;

namespace Patterns.Behavioral.State
{
    public class Gas : IWaterState
    {
        public void Heat(Water context)
        {
        }

        public void Cold(Water context)
        {
            Console.WriteLine("Превращение пара в воду");
            context.State = new Liquid();
        }
    }
}