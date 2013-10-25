using DodgeballGame.Stats;
using NUnit.Framework;

namespace DodgeballGame.Tests.Stats
{
    [TestFixture]
    public class StrengthStat_UT
    {
        private IStat _testObject;

        [SetUp]
        public void SetUp()
        {
            _testObject = new StrengthStat();
        }

        [Test]
        public void Constructor_Sets_CurrentValue_And_BaseValue_Equal_To_Parameter()
        {
            const int givenValue = 2;

            var testObject = new StrengthStat(givenValue);
            Assert.That(testObject.BaseValue, Is.EqualTo(givenValue));
            Assert.That(testObject.CurrentValue, Is.EqualTo(givenValue));
        }

        [Test]
        public void Value_Setter_Sets_Value()
        {
            var value = _testObject.Min + 1;
            _testObject.CurrentValue = value;
            Assert.That(_testObject.CurrentValue, Is.EqualTo(value));
        }

        [Test]
        public void Value_Setter_Obeys_Min_Limit()
        {
            _testObject.CurrentValue = _testObject.Min - 1;
            Assert.That(_testObject.CurrentValue, Is.EqualTo(_testObject.Min));
        }
    }
}
