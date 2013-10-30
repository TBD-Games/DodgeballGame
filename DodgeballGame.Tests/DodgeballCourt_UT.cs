using NUnit.Framework;

namespace DodgeballGame.Tests
{
    [TestFixture]
    public class DodgeballCourt_UT
    {
        [Test]
        public void Constructor_Initializes_Positions_With_Correct_Coordinates()
        {
            var testObject = new DodgeballCourt();

            var currentRowIndex = 0;
            var currentColumnIndex = 0;
            var position = testObject.Positions[currentRowIndex, currentColumnIndex];

            Assert.That(position.XCoord, Is.EqualTo(currentColumnIndex));
            Assert.That(position.YCoord, Is.EqualTo(currentRowIndex));


            currentRowIndex = 1;
            currentColumnIndex = 4;
            position = testObject.Positions[currentRowIndex, currentColumnIndex];

            Assert.That(position.XCoord, Is.EqualTo(currentColumnIndex));
            Assert.That(position.YCoord, Is.EqualTo(currentRowIndex));


            var lastRowIndex = testObject.Positions.GetUpperBound(0);
            var lastColumnIndex = testObject.Positions.GetUpperBound(1);
            position = testObject.Positions[lastRowIndex, lastColumnIndex];

            Assert.That(position.XCoord, Is.EqualTo(lastColumnIndex));
            Assert.That(position.YCoord, Is.EqualTo(lastRowIndex));
        }
    }
}
