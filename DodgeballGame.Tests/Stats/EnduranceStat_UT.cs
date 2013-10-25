using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DodgeballGame.Stats;
using NUnit.Framework;

namespace DodgeballGame.Tests.Stats
{
    [TestFixture]
    public class EnduranceStat_UT
    {
        private IStat _testObject;

        [SetUp]
        public void SetUp()
        {
            _testObject = new EnduranceStat();
        }

        [Test]
        public void Value_Setter_Sets_Value()
        {
            var value = _testObject.Min + 1;
            _testObject.Value = value;
            Assert.That(_testObject.Value, Is.EqualTo(value));
        }

        [Test]
        public void Value_Setter_Obeys_Min_Limit()
        {
            _testObject.Value = _testObject.Min - 1;
            Assert.That(_testObject.Value, Is.EqualTo(_testObject.Min));
        }
    }
}
