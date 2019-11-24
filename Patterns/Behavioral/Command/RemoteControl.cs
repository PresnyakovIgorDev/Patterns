namespace Patterns.Behavioral.Command
{
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ClickExecute()
        {
            _command?.Execute();
        }

        public void ClickUndo()
        {
            _command?.Undo();
        }
    }
}