namespace Patterns.Creational.Builder
{
    public class CoffeeDirector
    {
        public CoffeeDirector()
        {
        }

        public Coffee Build(ICoffeeBuilder builder)
        {
            builder.SetCoffee();
            builder.SetAdditional();

            return builder.GetResult();
        }
    }
}