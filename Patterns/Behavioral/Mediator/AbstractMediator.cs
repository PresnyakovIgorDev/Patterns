namespace Patterns.Behavioral.Mediator
{
    /// <summary>
    ///     Посредник (Mediator) представляет такой шаблон проектирования, который обеспечивает взаимодействие множества
    ///     объектов без необходимости ссылаться друг на друга. Тем самым достигается слабосвязанность взаимодействующих
    ///     объектов.
    /// </summary>
    public abstract class AbstractMediator
    {
        public abstract void Send(string msg, AbstractColleuge sender);
    }
}