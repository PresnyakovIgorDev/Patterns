using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational.Factory_Method
{
    /// <summary>
    /// Фабричный метод (Factory Method) - это паттерн, который определяет интерфейс для создания объектов некоторого класса, но непосредственное решение о том, объект какого класса создавать происходит в подклассах. То есть паттерн предполагает, что базовый класс делегирует создание объектов классам-наследникам.
    /// </summary>
    public interface ICreator
    {
        IFabricMethodObject FactoryMethod();
    }
}
