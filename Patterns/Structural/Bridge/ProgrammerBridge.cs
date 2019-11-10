namespace Patterns.Structural.Bridge
{
    /// <summary>
    ///     Мост (Bridge) - структурный шаблон проектирования, который позволяет отделить абстракцию от реализации таким
    ///     образом, чтобы и абстракцию, и реализацию можно было изменять независимо друг от друга.
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