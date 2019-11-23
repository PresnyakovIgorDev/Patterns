using System;

namespace Patterns.Behavioral.Chain_of_responsibility
{
    public class MaestroHandler : BasicHandler
    {
        public override void Handle(Request request)
        {
            if(request.PaymentType == PaymentType.Maestro)
                Console.WriteLine("Обработка Maestro");
            else
                Successor?.Handle(request);
        }

        public MaestroHandler(BasicHandler successor) : base(successor)
        {
        }
    }
}