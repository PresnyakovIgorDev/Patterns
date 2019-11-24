using System;

namespace Patterns.Behavioral.Mediator
{
    public class FirstColleuge : AbstractColleuge
    {
        public FirstColleuge(AbstractMediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("FirsColleugeRecieve " + message);
        }
    }
}