namespace Patterns.Behavioral.Memento
{
    public class GameHeroState
    {
        public int Lives { get; }
        public int Patrons { get; }

        public GameHeroState(int lives, int patrons)
        {
            Lives = lives;
            Patrons = patrons;
        }

        public override string ToString()
        {
            return $"Жизни {Lives} Патроны {Patrons}";
        }
    }
}