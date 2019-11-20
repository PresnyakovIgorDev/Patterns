namespace Patterns.Structural.Flyweight
{
    /// <summary>
    /// Паттерн Приспособленец (Flyweight) - структурный шаблон проектирования, который позволяет использовать разделяемые объекты сразу в нескольких контекстах. Данный паттерн используется преимущественно для оптимизации работы с памятью.
    /// </summary>
    public abstract class AbstractCharForDrawingFlyweight
    {
        protected char _symbol;

        public AbstractCharForDrawingFlyweight(char symbol)
        {
            _symbol = symbol;
        }
        public abstract void DrawChar(DrawContext context);
    }
}