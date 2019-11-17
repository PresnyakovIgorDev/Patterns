namespace Patterns.Structural.Decorator
{
    /// <summary>
    /// Декоратор (Decorator) представляет структурный шаблон проектирования, который позволяет динамически подключать к объекту дополнительную функциональность.
    /// Декоратор предоставляет расширенный интерфейс. Заместитель предоставляет тот же интерфейс.
    /// </summary>
    public abstract class PizzaDecorator : Pizza
    {
        protected readonly Pizza _pizza;

        protected PizzaDecorator(Pizza pizza,string title) : base(title)
        {
            _pizza = pizza;
        }
    }
}