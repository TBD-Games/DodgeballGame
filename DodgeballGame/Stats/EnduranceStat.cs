
namespace DodgeballGame.Stats
{
    public interface IEnduranceStat : IStat
    {}

    public class EnduranceStat : IEnduranceStat
    {
        private const string _displayName = "Endurance";
        private readonly int _baseValue;
        private int _currentValue;
        private const int _min = 0;

        public EnduranceStat() : this(_min)
        {}

        public EnduranceStat(int baseValue)
        {
            _baseValue = baseValue;
            CurrentValue = baseValue;
        }

        public string DisplayName
        {
            get { return _displayName; }
        }

        public int BaseValue
        {
            get { return _baseValue; }
        }

        public int CurrentValue
        {
            get { return _currentValue; }
            set { _currentValue = value < _min ? _min : value; }
        }

        public int Min
        {
            get { return _min; }
        }
    }
}
