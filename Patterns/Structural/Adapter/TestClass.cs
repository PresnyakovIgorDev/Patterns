namespace Patterns.Structural.Adapter
{
    public static class TestClass
    {
        public static void Execute(ITargetClass target)
        {
            target.Start();
        }
    }
}