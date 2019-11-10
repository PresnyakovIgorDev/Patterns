using System;

namespace Patterns.Structural.Bridge
{
    public class CPlusPlus : ILanguage
    {
        public void WriteCode()
        {
            Console.WriteLine("Пишем на C++");
        }
    }
}