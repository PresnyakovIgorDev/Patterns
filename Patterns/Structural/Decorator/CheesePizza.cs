namespace Patterns.Structural.Decorator
{
    public class  CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza, pizza.Title + ", сыром")
        {
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 30;
        }
    }
}