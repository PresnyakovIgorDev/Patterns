using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational
{
    /// <summary>
    /// Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует, что для определенного класса будет создан только один объект, а также предоставит к этому объекту точку доступа.
    /// </summary>
    public class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        public string TestProperty { get; set; }

        private Singleton()
        {
            TestProperty = "Test";
        }

        /// <summary>
        /// Получить инстанс Singleton
        /// </summary>
        public static Singleton Instance => _instance;
    }
}
