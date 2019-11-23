using System;

namespace Patterns.Behavioral.Chain_of_responsibility
{
    public class MastercardHandler : BasicHandler
    {
        public override void Handle(Request request)
        {
            if(request.PaymentType == PaymentType.MasterCard)
                Console.WriteLine("Обработка MasterCard");
            else
                Successor?.Handle(request);
        }

        public MastercardHandler(BasicHandler successor) : base(successor)
        {
        }
    }
}