namespace Patterns.Behavioral.State
{
    /// <summary>
    ///     Context
    /// </summary>
    public class Water
    {
        public IWaterState State { get; set; }

        public Water(IWaterState state)
        {
            State = state;
        }

        public void Heat()
        {
            State.Heat(this);
        }

        public void Cold()
        {
            State.Cold(this);
        }
    }
}