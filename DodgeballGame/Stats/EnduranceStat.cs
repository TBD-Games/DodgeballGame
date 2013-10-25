using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DodgeballGame.Stats
{
    public class EnduranceStat : IStat
    {
        private const string _displayName = "Endurance";
        private int _value;
        private const int _min = 0;

        public EnduranceStat() : this(_min)
        {}

        public EnduranceStat(int value)
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
