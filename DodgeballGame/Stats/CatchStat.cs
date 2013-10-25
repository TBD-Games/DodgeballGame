
namespace DodgeballGame.Stats
{
    public interface ICatchStat : IStat 
    {}

    public class CatchStat : ICatchStat
    {
        private const string _displayName = "Catch";
        private readonly int _baseValue;
        private int _currentValue;
        private const int _min = 1;

        public CatchStat() : this(_min)
        {}

        public CatchStat(int baseValue)
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
