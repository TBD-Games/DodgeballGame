using DodgeballGame.Roles;
using DodgeballGame.Stats;

namespace DodgeballGame
{
    public interface IDodgeballPlayer
    {
        IRole Role { get; }

        IStat Strength { get; }
        IStat Accuracy { get; }
        IStat Dodge { get; }
        IStat Catch { get; }
        IStat Speed { get; }

        IPosition Position { get; set; }
        bool InOutStatus { get; set; }
    }

    public class DodgeballPlayer : IDodgeballPlayer
    {
        public IRole Role { get; protected internal set; }

        public IStat Strength { get; protected internal set; }
        public IStat Accuracy { get; protected internal set; }
        public IStat Dodge { get; protected internal set; }
        public IStat Catch { get; protected internal set; }
        public IStat Speed { get; protected internal set; }
        public IStat Endurance { get; protected internal set; }

        public IPosition Position { get; set; }
        public bool InOutStatus { get; set; }

        public DodgeballPlayer(IRole role)
        {
            Role = role;

            Strength = new StrengthStat(role.BaseStrength);
            Accuracy = new AccuracyStat(role.BaseAccuracy);
            Dodge = new DodgeStat(role.BaseDodge);
            Catch = new CatchStat(role.BaseCatch);
            Speed = new SpeedStat(role.BaseSpeed);
            Endurance = new EnduranceStat(role.BaseEndurance);
        }
    }
}
