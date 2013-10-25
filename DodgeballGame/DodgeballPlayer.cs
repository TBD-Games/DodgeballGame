using DodgeballGame.Roles;
using DodgeballGame.Stats;

namespace DodgeballGame
{
    public interface IDodgeballPlayer
    {
        IRole Role { get; }

        IStrengthStat Strength { get; }
        IAccuracyStat Accuracy { get; }
        IDodgeStat Dodge { get; }
        ICatchStat Catch { get; }
        ISpeedStat Speed { get; }
        IEnduranceStat Endurance { get; }

        IPosition Position { get; set; }
        bool InOutStatus { get; set; }
    }

    public class DodgeballPlayer : IDodgeballPlayer
    {
        public IRole Role { get; protected internal set; }

        public IStrengthStat Strength { get; protected internal set; }
        public IAccuracyStat Accuracy { get; protected internal set; }
        public IDodgeStat Dodge { get; protected internal set; }
        public ICatchStat Catch { get; protected internal set; }
        public ISpeedStat Speed { get; protected internal set; }
        public IEnduranceStat Endurance { get; protected internal set; }

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
