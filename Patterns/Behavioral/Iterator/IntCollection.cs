using System.Collections.Generic;

namespace Patterns.Behavioral.Iterator
{
    public class IntCollection : IAggregate<int>
    {
        private readonly List<int> _items = new List<int>();

        public IIterator<int> GetIterator()
        {
            return new IntIterator(this);
        }

        public int Count => _items.Count;

        public int this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }
    }
}