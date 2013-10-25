using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DodgeballGame.Stats
{
    public class DodgeStat : IStat
    {
        private const string _displayName = "Dodge";
        private int _value;
        private const int _min = 1;

        public DodgeStat() : this(_min)
        {}

        public DodgeStat(int value)
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
