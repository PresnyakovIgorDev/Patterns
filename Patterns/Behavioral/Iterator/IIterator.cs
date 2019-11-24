namespace Patterns.Behavioral.Iterator
{
    /// <summary>
    /// Паттерн Итератор (Iterator) предоставляет абстрактный интерфейс для последовательного доступа ко всем элементам составного объекта без раскрытия его внутренней структуры.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IIterator<T>
    {
        T First();
        T Next();
        bool IsDone();
        T CurrentItem();
    }
}