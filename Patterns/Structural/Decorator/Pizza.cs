namespace Patterns.Structural.Decorator
{
    public abstract class Pizza
    {
        public string Title { get; }

        protected Pizza(string title)
        {
            Title = title;
        }

        public abstract int GetCost();
    }
}