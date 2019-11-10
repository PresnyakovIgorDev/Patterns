using System;

namespace Patterns.Structural.Bridge
{
    public class RegularProgrammer : ProgrammerBridge
    {
        public RegularProgrammer(ILanguage language) : base(language)
        {
        }

        public override void GetSalary()
        {
            Console.WriteLine("Зарплата в конце месяца");
        }
    }
}