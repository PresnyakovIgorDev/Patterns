namespace Patterns.Creational.Abstract_factory
{
    public class FirstFactory : IAbstractFactory
    {
        public IAObject GetAObject()
        {
            return new FirstAObject();
        }

        public IBObject GetBObject()
        {
            return new FirstBObject();
        }
    }
}