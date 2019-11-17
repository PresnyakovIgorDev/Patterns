namespace Patterns.Structural.Decorator
{
    public class RussianPizza : Pizza
    {
        public RussianPizza() : base("Русская пицца")
        {
        }

        public override int GetCost()
        {
            return 100;
        }
    }
}