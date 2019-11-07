namespace Patterns.Creational.Builder
{
    public class Coffee
    {
        public string CoffeeType { get; set; }
        public string[] Additional { get; set; } = new string[0];

        public override string ToString()
        {
            return CoffeeType + ", " + string.Join(",",Additional);
        }

    }
}