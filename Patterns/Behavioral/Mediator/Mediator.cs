namespace Patterns.Behavioral.Mediator
{
    public class Mediator : AbstractMediator
    {
        public FirstColleuge FirstColleuge { get; set; }
        public SecondColleuge SecondColleuge { get; set; }

        public override void Send(string msg, AbstractColleuge sender)
        {
            if (sender == FirstColleuge)
                SecondColleuge.Notify(msg);
            else
                FirstColleuge.Notify(msg);
        }
    }
}