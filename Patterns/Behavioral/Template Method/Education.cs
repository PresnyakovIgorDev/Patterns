namespace Patterns.Behavioral.Template_Method
{
    /// <summary>
    ///     Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов, позволяя им переопределить
    ///     отдельные шаги этого алгоритма без изменения его структуры.
    /// </summary>
    public abstract class Education
    {
        public void Learn()
        {
            Study();
            PassExams();
        }

        public abstract void Study();
        public abstract void PassExams();
    }
}