namespace Patterns.Behavioral.State
{
    /// <summary>
    ///     Состояние (State) - шаблон проектирования, который позволяет объекту изменять свое поведение в зависимости от
    ///     внутреннего состояния.
    /// </summary>
    public interface IWaterState
    {
        void Heat(Water context);
        void Cold(Water context);
    }
}