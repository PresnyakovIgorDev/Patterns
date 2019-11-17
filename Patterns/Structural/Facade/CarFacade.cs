namespace Patterns.Structural.Facade
{
    /// <summary>
    /// Фасад — это структурный паттерн проектирования, который предоставляет простой интерфейс к сложной системе классов, библиотеке или фреймворку.
    /// </summary>
    public class CarFacade
    {
        private Engine _engine;
        private Transmission _transmission;
        private Control _control;

        public CarFacade(Engine engine, Transmission transmission, Control control)
        {
            _engine = engine;
            _transmission = transmission;
            _control = control;
        }

        public void Start()
        {
            _transmission.Neutral();
            _engine.StartEngine();
        }

        public void Stop()
        {
            _transmission.Neutral();
            _engine.StopEngine();
        }

        public void MoveToHome()
        {
            _transmission.Forward();
            _control.Forward();
            _control.Left();
            _control.Right();
        }
    }
}