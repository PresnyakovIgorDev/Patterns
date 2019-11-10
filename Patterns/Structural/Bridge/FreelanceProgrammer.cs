using System;

namespace Patterns.Structural.Bridge
{
    public class FreelanceProgrammer : ProgrammerBridge
    {
        public FreelanceProgrammer(ILanguage language) : base(language)
        {
        }

        public override void GetSalary()
        {
            Console.WriteLine("Зарплата за заказ");
        }
    }
}