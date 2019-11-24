using System;

namespace Patterns.Behavioral.Mediator
{
    public class SecondColleuge : AbstractColleuge
    {
        public SecondColleuge(AbstractMediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("SecondColleugeRecieve " + message);
        }
    }
}