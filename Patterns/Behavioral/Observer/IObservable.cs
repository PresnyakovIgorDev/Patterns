namespace Patterns.Behavioral.Observer
{
    public interface IObservable<T>
    {
        void AddObserver(IObserver<T> observer);
        void Remove(IObserver<T> observer);
    }
}