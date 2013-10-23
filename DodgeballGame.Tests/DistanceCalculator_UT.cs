using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DodgeballGame.Tests
{
    [TestFixture]
    public class DistanceCalculator_UT
    {
        [Test]
        public void DistanceCalculator_Computes_Correctly_For_Positive_Numbers()
        {
            var position1 = new Position(4, 1);
            var position2 = new Position(1, 5);

            var result = DistanceCalculator.CalculateDistance(position1, position2);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void DistanceCalculator_Computes_Correctly_For_Negative_Numbers()
        {
            var position1 = new Position(-2, -3);
            var position2 = new Position(-4, -10);

            var result = DistanceCalculator.CalculateDistance(position1, position2);
            Assert.That(Math.Round(result, 2), Is.EqualTo(7.28));
        }
    }
}
