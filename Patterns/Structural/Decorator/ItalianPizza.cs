namespace Patterns.Structural.Decorator
{
    public class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        {
        }

        public override int GetCost()
        {
            return 120;
        }
    }
}