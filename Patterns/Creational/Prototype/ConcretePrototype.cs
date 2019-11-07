namespace Patterns.Creational
{
    public class ConcretePrototype : Prototype
    {
        public ConcretePrototype(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}