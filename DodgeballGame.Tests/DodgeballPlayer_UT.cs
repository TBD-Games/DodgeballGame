using DodgeballGame.Roles;
using DodgeballGame.Stats;
using NUnit.Framework;
using Rhino.Mocks;

namespace DodgeballGame.Tests
{
    [TestFixture]
    public class DodgeballPlayer_UT
    {
        private IRole _role;
        private IStatCollectionBuilder _statCollectionBuilder;
        private DodgeballPlayer _testObject;

        [SetUp]
        public void SetUp()
        {
            _role = MockRepository.GenerateMock<IRole>();
            _statCollectionBuilder = MockRepository.GenerateMock<IStatCollectionBuilder>();
            _testObject = new DodgeballPlayer(_role, _statCollectionBuilder);
        }

        [TearDown]
        public void TearDown()
        {
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
    }
}
