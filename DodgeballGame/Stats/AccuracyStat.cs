
namespace DodgeballGame.Stats
{
    public class AccuracyStat : IStat
    {
        private const string _displayName = "Accuracy";
        private int _value;
        private const int _min = 1;

        public AccuracyStat() : this(_min)
        {}

        public AccuracyStat(int value)
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
