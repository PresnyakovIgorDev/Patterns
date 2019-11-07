using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational.Abstract_factory
{
    /// <summary>
    /// Паттерн "Абстрактная фабрика" (Abstract Factory) предоставляет интерфейс для создания семейств взаимосвязанных объектов с определенными интерфейсами без указания конкретных типов данных объектов.
    /// </summary>
    public interface IAbstractFactory
    {
        IAObject GetAObject();
        IBObject GetBObject();
    }
}
