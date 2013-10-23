using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DodgeballGame
{
    public interface IPosition
    {
        int XCoord { get; set; }
        int YCoord { get; set; }
    }

    public class Position : IPosition
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }

        public Position(int xCoord, int yCoord)
        {
            XCoord = xCoord;
            YCoord = yCoord;
        }
    }
}
