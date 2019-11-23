using System;

namespace Patterns.Behavioral.Chain_of_responsibility
{
    public class VisaHandler : BasicHandler
    {
        public override void Handle(Request request)
        {
            if(request.PaymentType == PaymentType.Visa)
                Console.WriteLine("Обработка Visa");
            else
                Successor?.Handle(request);
        }

        public VisaHandler(BasicHandler successor) : base(successor)
        {
        }
    }
}