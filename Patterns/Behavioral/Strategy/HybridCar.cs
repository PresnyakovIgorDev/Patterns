namespace Patterns.Behavioral.Strategy
{
    public class HybridCar
    {
        private IMovableStrategy _strategy;

        public HybridCar(IMovableStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IMovableStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Move()
        {
            _strategy.Move();
        }
    }
}