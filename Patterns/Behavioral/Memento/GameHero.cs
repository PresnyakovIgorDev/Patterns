using System;

namespace Patterns.Behavioral.Memento
{
    public class GameHero
    {
        private int _lives = 100;
        private int _patrons = 20;

        public GameHeroState GetState()
        {
            var state = new GameHeroState(_lives, _patrons);
            Console.WriteLine($"Сохранено: {state}");
            return state;
        }

        public void RestoreState(GameHeroState state)
        {
            _lives = state.Lives;
            _patrons = state.Patrons;
            Console.WriteLine($"Востановленно: {state}");
        }

        public void Shoot()
        {
            _patrons--;
        }

        public void AddHealth()
        {
            _lives += 20;
        }
    }
}