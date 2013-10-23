using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DodgeballGame
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(IPosition position1, IPosition position2)
        {
            var xPortion = (position2.XCoord - position1.XCoord) * (position2.XCoord - position1.XCoord);
            var yPortion = (position2.YCoord - position1.YCoord) * (position2.YCoord - position1.YCoord);

            return Math.Sqrt(xPortion + yPortion);
        }
    }
}
