using DodgeballGame.Roles;
using DodgeballGame.Stats;

namespace DodgeballGame
{
    public interface IDodgeballPlayer
    {
        IRole Role { get; }

        IStatCollection Stats { get; }

        IPosition Position { get; set; }
        bool InOutStatus { get; set; }
    }

    public class DodgeballPlayer : IDodgeballPlayer
    {
        public IRole Role { get; protected internal set; }

        public IStatCollection Stats { get; protected internal set; }

        public IPosition Position { get; set; }
        public bool InOutStatus { get; set; }

        public DodgeballPlayer(IRole role) : this(role, new StatCollectionBuilder())
        {}

        public DodgeballPlayer(IRole role, IStatCollectionBuilder statCollectionBuilder)
        {
            Role = role;
            Stats = statCollectionBuilder.BuildStatCollection(role);
        }
    }
}
