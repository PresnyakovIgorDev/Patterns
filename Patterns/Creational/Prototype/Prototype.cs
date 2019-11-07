using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational
{
    /// <summary>
    /// рототип (Prototype) позволяет создавать объекты на основе уже ранее созданных объектов-прототипов. То есть по сути данный паттерн предлагает технику клонирования объектов
    /// </summary>
    public abstract class Prototype
    {
        protected Prototype(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public abstract Prototype Clone();
    }
}
