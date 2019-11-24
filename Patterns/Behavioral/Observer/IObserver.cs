namespace Patterns.Behavioral.Observer
{
    /// <summary>
    /// Наблюдатель — это поведенческий паттерн проектирования, который создаёт механизм подписки, позволяющий одним объектам следить и реагировать на события, происходящие в других объектах.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IObserver<T>
    {
        void Update(T value);
    }
}