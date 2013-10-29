using DodgeballGame.Roles;
using DodgeballGame.Stats;
using NUnit.Framework;
using Rhino.Mocks;

namespace DodgeballGame.Tests.Stats
{
    [TestFixture]
    public class StatCollectionBuilder_UT
    {
        private IRole _role;
        private StatCollectionBuilder _testObject;

        [SetUp]
        public void SetUp()
        {
            _role = MockRepository.GenerateMock<IRole>();
            _testObject = new StatCollectionBuilder();
        }

        [TearDown]
        public void TearDown()
        {
            _role.VerifyAllExpectations();
        }

        [Test]
        public void BuildStatCollection_Sets_Up_Strength_Stat_Based_BaseStrength_Of_Role()
        {
            const int strength = 2;

            _role.Expect(r => r.BaseStrength).Return(strength);

            var statCollection = _testObject.BuildStatCollection(_role);
            Assert.That(statCollection.Strength.CurrentValue, Is.EqualTo(strength));
        }

        [Test]
        public void BuildStatCollection_Sets_Up_Accuracy_Stat_Based_BaseAccuracy_Of_Role()
        {
            const int accuracy = 2;

            _role.Expect(r => r.BaseAccuracy).Return(accuracy);

            var statCollection = _testObject.BuildStatCollection(_role);
            Assert.That(statCollection.Accuracy.CurrentValue, Is.EqualTo(accuracy));
        }

        [Test]
        public void BuildStatCollection_Sets_Up_Dodge_Stat_Based_BaseDodge_Of_Role()
        {
            const int dodge = 2;

            _role.Expect(r => r.BaseDodge).Return(dodge);

            var statCollection = _testObject.BuildStatCollection(_role);
            Assert.That(statCollection.Dodge.CurrentValue, Is.EqualTo(dodge));
        }

        [Test]
        public void BuildStatCollection_Sets_Up_Catch_Stat_Based_BaseCatch_Of_Role()
        {
            const int catchValue = 2;

            _role.Expect(r => r.BaseCatch).Return(catchValue);

            var statCollection = _testObject.BuildStatCollection(_role);
            Assert.That(statCollection.Catch.CurrentValue, Is.EqualTo(catchValue));
        }

        [Test]
        public void BuildStatCollection_Sets_Up_Speed_Stat_Based_BaseSpeed_Of_Role()
        {
            const int speed = 2;

            _role.Expect(r => r.BaseSpeed).Return(speed);

            var statCollection = _testObject.BuildStatCollection(_role);
            Assert.That(statCollection.Speed.CurrentValue, Is.EqualTo(speed));
        }

        [Test]
        public void BuildStatCollection_Sets_Up_Endurance_Stat_Based_BaseEndurance_Of_Role()
        {
            const int endurance = 2;

            _role.Expect(r => r.BaseEndurance).Return(endurance);

            var statCollection = _testObject.BuildStatCollection(_role);
            Assert.That(statCollection.Endurance.CurrentValue, Is.EqualTo(endurance));
        }
    }
}
