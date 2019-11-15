namespace Patterns.Structural.Bridge
{
    /// <summary>
    ///Мост — это структурный паттерн проектирования, который разделяет один или несколько классов на две отдельные иерархии — абстракцию и реализацию, позволяя изменять их независимо друг от друга.
    /// </summary>
    public abstract class ProgrammerBridge
    {
        private readonly ILanguage _language;

        protected ProgrammerBridge(ILanguage language)
        {
            _language = language;
        }

        public void DoWork()
        {
            _language.WriteCode();
        }

        public abstract void GetSalary();
    }
}