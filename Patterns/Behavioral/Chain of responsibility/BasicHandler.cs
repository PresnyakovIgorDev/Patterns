namespace Patterns.Behavioral.Chain_of_responsibility
{
    /// <summary>
    /// Цепочка Обязанностей (Chain of responsibility) - поведенческий шаблон проектирования, который позволяет избежать жесткой привязки отправителя запроса к получателю, позволяя нескольким объектам обработать запрос. Все возможные обработчики запроса образуют цепочку, а сам запрос перемещается по этой цепочке, пока один из ее объектов не обработает запрос. Каждый объект при получении запроса выбирает, либо обработать запрос, либо передать выполнение запроса следующему по цепочке.
    /// </summary>
    public abstract class BasicHandler
    {
        public BasicHandler Successor { get; }
        public abstract void Handle(Request request);

        public BasicHandler(BasicHandler successor)
        {
            Successor = successor;
        }
    }
}