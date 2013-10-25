
namespace DodgeballGame.Stats
{
    public class StrengthStat : IStat
    {
        private const string _displayName = "Strength";
        private int _value;
        private const int _min = 1;

        public StrengthStat() : this(_min)
        {}

        public StrengthStat(int value)
        {
            Value = value;
        }

        public string DisplayName
        {
            get { return _displayName; }
        }

        public int Value
        {
            get
            {
                return _value;
            }
            set {
                _value = value < _min ? _min : value;
            }
        }

        public int Min
        {
            get { return _min; }
        }
    }
}
