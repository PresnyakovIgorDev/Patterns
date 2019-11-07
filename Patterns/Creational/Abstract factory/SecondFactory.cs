namespace Patterns.Creational.Abstract_factory
{
    public class SecondFactory : IAbstractFactory
    {
        public IAObject GetAObject()
        {
            return new SecondAObject();
        }

        public IBObject GetBObject()
        {
            return  new SecondBObject();
        }
    }
}