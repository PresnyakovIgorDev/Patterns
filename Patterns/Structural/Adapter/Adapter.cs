namespace Patterns.Structural.Adapter
{
    /// <summary>
    /// Адаптер — это структурный паттерн проектирования, который позволяет объектам с несовместимыми интерфейсами работать вместе.
    /// </summary>
    public class Adapter : ITargetClass
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        
        public void Start()
        {
            _adaptee.Execute();
        }
    }
}