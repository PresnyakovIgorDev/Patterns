namespace Patterns.Structural.Composite
{
    /// <summary>
    /// Паттерн Компоновщик (Composite) объединяет группы объектов в древовидную структуру по принципу "часть-целое и позволяет клиенту одинаково работать как с отдельными объектами, так и с группой объектов.
    /// </summary>
    public abstract class Component
    {
        public string Name { get; }
        public int Cost { get; }

        public Component(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract int GetFullCost();
        public abstract void Display();
    }
}