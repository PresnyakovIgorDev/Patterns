using System;
using System.Collections.Generic;

namespace Patterns.Structural.Flyweight
{
    public class CharFabric
    {
        private Dictionary<char, AbstractCharForDrawingFlyweight> _flyweights = new Dictionary<char, AbstractCharForDrawingFlyweight>();
        public CharFabric()
        {
            
        }

        public AbstractCharForDrawingFlyweight GetCharForDrawing(char symbol)
        {
            if (!_flyweights.ContainsKey(symbol))
            {
                Console.WriteLine("Создание flyweight для " + symbol);
                _flyweights.Add(symbol, new CharForDrawingFlyweight(symbol));
            }

            return _flyweights[symbol];
        }
    }
}