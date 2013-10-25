
namespace DodgeballGame.Stats
{
    public interface IAccuracyStat : IStat
    {}

    public class AccuracyStat : IAccuracyStat
    {
        private const string _displayName = "Accuracy";
        private readonly int _baseValue;
        private int _currentValue;
        private const int _min = 1;

        public AccuracyStat() : this(_min)
        {}

        public AccuracyStat(int baseValue)
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
