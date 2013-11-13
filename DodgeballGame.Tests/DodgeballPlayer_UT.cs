using DodgeballGame.Roles;
using DodgeballGame.Stats;
using NUnit.Framework;
using Rhino.Mocks;

namespace DodgeballGame.Tests
{
    [TestFixture]
    public class DodgeballPlayer_UT
    {
        private ISpeedStat _speedStat;
        private IStatCollection _statCollection;

        private IRole _role;
        private IStatCollectionBuilder _statCollectionBuilder;
        private DodgeballPlayer _testObject;

        [SetUp]
        public void SetUp()
        {
            _speedStat = MockRepository.GenerateMock<ISpeedStat>();
            _statCollection = MockRepository.GenerateMock<IStatCollection>();

            _role = MockRepository.GenerateMock<IRole>();
            _statCollectionBuilder = MockRepository.GenerateMock<IStatCollectionBuilder>();
            _testObject = new DodgeballPlayer(_role, _statCollectionBuilder);
        }

        [TearDown]
        public void TearDown()
        {
            _speedStat.VerifyAllExpectations();
            _statCollection.VerifyAllExpectations();
            _role.VerifyAllExpectations();
            _statCollectionBuilder.VerifyAllExpectations();
        }

        [Test]
        public void Constructor_Uses_StatCollectionBuilder_To_Set_Up_StatsCollection()
        {
            var statCollection = new StatCollection();

            _statCollectionBuilder.Expect(s => s.BuildStatCollection(_role)).Return(statCollection);

            var testObject = new DodgeballPlayer(_role, _statCollectionBuilder);
            Assert.That(testObject.Stats, Is.SameAs(statCollection));
        }

        [Test]
        public void CalculateMoveEnduranceCost_Returns_Zero_If_Distance_Not_Greater_Than_Speed()
        {
            const int distance = 1;
            const int speedValue = 2;
            const int expectedEnduranceCost = 0;

            _testObject.Stats = _statCollection;

            _statCollection.Expect(s => s.Speed).Return(_speedStat);
            _speedStat.Expect(s => s.CurrentValue).Return(speedValue);

            var result = _testObject.CalculateMoveEnduranceCost(distance);
            Assert.That(result, Is.EqualTo(expectedEnduranceCost));
        }

        [Test]
        public void CalculateMoveEnduranceCost_Returns_One_If_Distance_One_Greater_Than_Speed()
        {
            const int distance = 3;
            const int speedValue = 2;
            const int expectedEnduranceCost = 1;

            _testObject.Stats = _statCollection;

            _statCollection.Expect(s => s.Speed).Return(_speedStat);
            _speedStat.Expect(s => s.CurrentValue).Return(speedValue);

            var result = _testObject.CalculateMoveEnduranceCost(distance);
            Assert.That(result, Is.EqualTo(expectedEnduranceCost));
        }

        [Test]
        public void CalculateMoveEnduranceCost_Returns_Three_If_Distance_Two_Greater_Than_Speed()
        {
            const int distance = 4;
            const int speedValue = 2;
            const int expectedEnduranceCost = 3;

            _testObject.Stats = _statCollection;

            _statCollection.Expect(s => s.Speed).Return(_speedStat);
            _speedStat.Expect(s => s.CurrentValue).Return(speedValue);

            var result = _testObject.CalculateMoveEnduranceCost(distance);
            Assert.That(result, Is.EqualTo(expectedEnduranceCost));
        }

        [Test]
        public void CalculateMoveEnduranceCost_Returns_Six_If_Distance_Three_Greater_Than_Speed()
        {
            const int distance = 5;
            const int speedValue = 2;
            const int expectedEnduranceCost = 6;

            _testObject.Stats = _statCollection;

            _statCollection.Expect(s => s.Speed).Return(_speedStat);
            _speedStat.Expect(s => s.CurrentValue).Return(speedValue);

            var result = _testObject.CalculateMoveEnduranceCost(distance);
            Assert.That(result, Is.EqualTo(expectedEnduranceCost));
        }
    }
}
