namespace Patterns.Creational.Factory_Method
{
    public class CreatorA : ICreator
    {
        public IFabricMethodObject FactoryMethod()
        {
            return new FabricMethodObjectA();
        }
    }
}