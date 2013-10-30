using DodgeballGame.Roles;
using DodgeballGame.Stats;

namespace DodgeballGame
{
    public interface IDodgeballPlayer
    {
        IRole Role { get; }

        IStatCollection Stats { get; }

        bool InOutStatus { get; set; }
    }

    public class DodgeballPlayer : IDodgeballPlayer
    {
        public IRole Role { get; protected internal set; }

        public IStatCollection Stats { get; protected internal set; }

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
