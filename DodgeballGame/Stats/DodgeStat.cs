
namespace DodgeballGame.Stats
{
    public interface IDodgeStat : IStat
    {}

    public class DodgeStat : IDodgeStat
    {
        private const string _displayName = "Dodge";
        private readonly int _baseValue;
        private int _currentValue;
        private const int _min = 1;

        public DodgeStat() : this(_min)
        {}

        public DodgeStat(int baseValue)
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
            get{ return _baseValue;}
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
