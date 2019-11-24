using System;

namespace Patterns.Behavioral.Template_Method
{
    public class School : Education
    {
        public override void Study()
        {
            Console.WriteLine("Учеба в школе");
        }

        public override void PassExams()
        {
            Console.WriteLine("Сдача экзаменов в школе");
        }
    }
}