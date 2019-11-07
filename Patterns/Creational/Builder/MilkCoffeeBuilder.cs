namespace Patterns.Creational.Builder
{
    public class MilkCoffeeBuilder : ICoffeeBuilder
    {
        private Coffee _coffee = new Coffee();
        public void SetCoffee()
        {
            _coffee.CoffeeType = "Арабика";
        }

        public void SetAdditional()
        {
            _coffee.Additional = new []{"Молоко"};

        }

        public Coffee GetResult()
        {
            return _coffee;
        }
    }
}