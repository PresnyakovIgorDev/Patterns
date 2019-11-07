namespace Patterns.Creational.Builder
{
    public class StandartCoffeeBuilder : ICoffeeBuilder
    {
        private Coffee _coffee = new Coffee();
        public void SetCoffee()
        {
            _coffee.CoffeeType = "Арабика";
        }

        public void SetAdditional()
        {
        }

        public Coffee GetResult()
        {
            return _coffee;
        }
    }
}