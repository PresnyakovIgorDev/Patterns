namespace Patterns.Behavioral.Command
{
    public class TVOnCommand : ICommand
    {
        private TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }
        
        public void Undo()
        {
            _tv.PowerOff();
        }

        public void Execute()
        {
            _tv.PowerOn();
        }
    }
}