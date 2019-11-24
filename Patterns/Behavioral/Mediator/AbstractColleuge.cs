namespace Patterns.Behavioral.Mediator
{
    public abstract class AbstractColleuge
    {
        protected AbstractMediator _mediator;

        protected AbstractColleuge(AbstractMediator mediator)
        {
            _mediator = mediator;
        }
    }
}