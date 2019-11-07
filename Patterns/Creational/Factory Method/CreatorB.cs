namespace Patterns.Creational.Factory_Method
{
    public class CreatorB : ICreator
    {
        public IFabricMethodObject FactoryMethod()
        {
            return new FabricMethodObjectB();
        }
    }
}