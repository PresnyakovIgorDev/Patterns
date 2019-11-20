namespace Patterns.Structural.Flyweight
{
    public class CharForDrawingFlyweight : AbstractCharForDrawingFlyweight
    {
        public CharForDrawingFlyweight(char symbol) : base(symbol)
        {
        }

        public override void DrawChar(DrawContext context)
        {
            context.Draw(_symbol.ToString());
        }
    }
}