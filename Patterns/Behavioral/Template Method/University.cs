using System;

namespace Patterns.Behavioral.Template_Method
{
    public class University : Education
    {
        public override void Study()
        {
            Console.WriteLine("Учеба в вузе");
        }

        public override void PassExams()
        {
            Console.WriteLine("Сдача экзаменов в вузе");
        }
    }
}