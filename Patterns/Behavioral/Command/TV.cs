using System;

namespace Patterns.Behavioral.Command
{
    public class TV
    {
        public void PowerOn()
        {
            Console.WriteLine("PowerOn");
        }

        public void PowerOff()
        {
            Console.WriteLine("PowerOff");
        }
    }
}