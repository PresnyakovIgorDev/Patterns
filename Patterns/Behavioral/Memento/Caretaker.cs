using System.Collections.Generic;

namespace Patterns.Behavioral.Memento
{
    public class Caretaker
    {
        public Stack<GameHeroState> States { get; } = new Stack<GameHeroState>();
    }
}