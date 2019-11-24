namespace Patterns.Behavioral.Iterator
{
    public interface IAggregate<T>
    {
        IIterator<T> GetIterator();
        int Count { get; }
        T this[int index] { get; set; }
    }
}