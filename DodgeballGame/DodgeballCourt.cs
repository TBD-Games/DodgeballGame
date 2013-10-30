

namespace DodgeballGame
{
    public interface IDodgeballCourt
    {
        IPosition[,] Positions { get; }
    }

    public class DodgeballCourt : IDodgeballCourt
    {
        private readonly IPosition[,] _positions = new IPosition[8, 16];
        public IPosition[,] Positions
        {
            get { return _positions; }
        }

        public DodgeballCourt()
        {
            for (var rowIndex = 0; rowIndex < _positions.GetLength(0); rowIndex++)
            {
                for (var columnIndex = 0; columnIndex < _positions.GetLength(1); columnIndex++)
                {
                    _positions[rowIndex, columnIndex] = new Position(columnIndex, rowIndex);
                }
            }
        }
    }
}
