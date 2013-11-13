using System.Collections.Generic;
using DodgeballGame.Roles;
using DodgeballGame.Stats;

namespace DodgeballGame
{
    public interface IDodgeballPlayer
    {
        IRole Role { get; }
        IStatCollection Stats { get; }
        IList<IDodgeball> HeldBalls { get; }
        bool InOutStatus { get; set; }

        int CalculateMoveEnduranceCost(int distance);
    }

    public class DodgeballPlayer : IDodgeballPlayer
    {
        public IRole Role { get; protected internal set; }
        public IStatCollection Stats { get; protected internal set; }
        public IList<IDodgeball> HeldBalls { get; protected internal set; }
        public bool InOutStatus { get; set; }

        public DodgeballPlayer(IRole role) : this(role, new StatCollectionBuilder())
        {}

        public DodgeballPlayer(IRole role, IStatCollectionBuilder statCollectionBuilder)
        {
            Role = role;
            Stats = statCollectionBuilder.BuildStatCollection(role);
        }

        public int CalculateMoveEnduranceCost(int distance)
        {
            var enduranceCost = 0;
            var distanceSpeedDifference = distance - Stats.Speed.CurrentValue;

            if (distanceSpeedDifference > 0)
            {
                enduranceCost = (distanceSpeedDifference*(distanceSpeedDifference + 1))/2;
            }

            return enduranceCost;
        }
    }
}
