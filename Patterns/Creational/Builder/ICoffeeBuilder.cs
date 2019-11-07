using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational.Builder
{
    /// <summary>
    /// Строитель (Builder) - шаблон проектирования, который инкапсулирует создание объекта и позволяет разделить его на различные этапы.
    /// 
    /// </summary>
    public interface ICoffeeBuilder
    {
        void SetCoffee();
        void SetAdditional();
        Coffee GetResult();
    }
}
