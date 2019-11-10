using System;

namespace Patterns.Structural.Bridge
{
    public class CSharp : ILanguage
    {
        public void WriteCode()
        {
            Console.WriteLine("Пишем на C#");
        }
    }
}