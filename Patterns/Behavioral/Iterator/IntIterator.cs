namespace Patterns.Behavioral.Iterator
{
    public class IntIterator : IIterator<int>
    {
        private readonly IntCollection _collection;
        private int _current;

        public IntIterator(IntCollection collection)
        {
            _collection = collection;
        }

        public int First()
        {
            return _collection[0];
        }

        public int Next()
        {
            _current++;

            if (_current >= _collection.Count)
                return 0;

            return _collection[_current];
        }

        public bool IsDone()
        {
            return _current >= _collection.Count;
        }

        public int CurrentItem()
        {
            return _collection[_current];
        }
    }
}