using DodgeballGame.Roles;
using NUnit.Framework;
using Rhino.Mocks;

namespace DodgeballGame.Tests
{
    [TestFixture]
    public class DodgeballPlayer_UT
    {
        private IRole _role;

        [SetUp]
        public void SetUp()
        {
            _role = MockRepository.GenerateMock<IRole>();
        }

        [TearDown]
        public void TearDown()
        {
            _role.VerifyAllExpectations();
        }

        [Test]
        public void Constructor_Sets_Up_Strength_Stat_Based_BaseStrength_Of_Role()
        {
            const int strength = 2;

            _role.Expect(r => r.BaseStrength).Return(strength);

            var testObject = new DodgeballPlayer(_role);
            Assert.That(testObject.Strength.CurrentValue, Is.EqualTo(strength));
        }

        [Test]
        public void Constructor_Sets_Up_Accuracy_Stat_Based_BaseAccuracy_Of_Role()
        {
            const int accuracy = 2;

            _role.Expect(r => r.BaseAccuracy).Return(accuracy);

            var testObject = new DodgeballPlayer(_role);
            Assert.That(testObject.Accuracy.CurrentValue, Is.EqualTo(accuracy));
        }

        [Test]
        public void Constructor_Sets_Up_Dodge_Stat_Based_BaseDodge_Of_Role()
        {
            const int dodge = 2;

            _role.Expect(r => r.BaseDodge).Return(dodge);

            var testObject = new DodgeballPlayer(_role);
            Assert.That(testObject.Dodge.CurrentValue, Is.EqualTo(dodge));
        }

        [Test]
        public void Constructor_Sets_Up_Catch_Stat_Based_BaseCatch_Of_Role()
        {
            const int catchValue = 2;

            _role.Expect(r => r.BaseCatch).Return(catchValue);

            var testObject = new DodgeballPlayer(_role);
            Assert.That(testObject.Catch.CurrentValue, Is.EqualTo(catchValue));
        }

        [Test]
        public void Constructor_Sets_Up_Speed_Stat_Based_BaseSpeed_Of_Role()
        {
            const int speed = 2;

            _role.Expect(r => r.BaseSpeed).Return(speed);

            var testObject = new DodgeballPlayer(_role);
            Assert.That(testObject.Speed.CurrentValue, Is.EqualTo(speed));
        }

        [Test]
        public void Constructor_Sets_Up_Endurance_Stat_Based_BaseEndurance_Of_Role()
        {
            const int endurance = 2;

            _role.Expect(r => r.BaseEndurance).Return(endurance);

            var testObject = new DodgeballPlayer(_role);
            Assert.That(testObject.Endurance.CurrentValue, Is.EqualTo(endurance));
        }
    }
}
