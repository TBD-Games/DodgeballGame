
namespace DodgeballGame
{
    public interface IPosition
    {
        int XCoord { get; set; }
        int YCoord { get; set; }

        IDodgeballPlayer Player { get; set; }
        IDodgeball FreeBall { get; set; }
    }

    public class Position : IPosition
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }

        public IDodgeballPlayer Player { get; set; }
        public IDodgeball FreeBall { get; set; }

        public Position(int xCoord, int yCoord)
        {
            XCoord = xCoord;
            YCoord = yCoord;
        }
    }
}
