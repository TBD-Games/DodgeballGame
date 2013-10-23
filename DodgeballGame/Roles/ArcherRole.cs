﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DodgeballGame.Roles
{
    public class ArcherRole : IRole
    {
        private const int _baseStrength = 6;
        private const int _baseSpeed = 3;
        private const int _baseAccuracy = 10;
        private const int _baseDodge = 4;
        private const int _baseCatch = 5;
        private const int _baseEndurance = 12;

        public int BaseStrength
        {
            get { return _baseStrength; }
        }
        public int BaseSpeed
        {
            get { return _baseSpeed; }
        }
        public int BaseAccuracy
        {
            get { return _baseAccuracy; }
        }
        public int BaseDodge
        {
            get { return _baseDodge; }
        }
        public int BaseCatch
        {
            get { return _baseCatch; }
        }
        public int BaseEndurance
        {
            get { return _baseEndurance; }
        }

        public int CurrentStrength { get; set; }
        public int CurrentSpeed { get; set; }
        public int CurrentAccuracy { get; set; }
        public int CurrentDodge { get; set; }
        public int CurrentCatch { get; set; }
        public int CurrentEndurance { get; set; }
    }
}
