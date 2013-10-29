using DodgeballGame.Roles;

namespace DodgeballGame.Stats
{
    public interface IStatCollectionBuilder
    {
        IStatCollection BuildStatCollection(IRole role);
    }

    public class StatCollectionBuilder : IStatCollectionBuilder
    {
        public IStatCollection BuildStatCollection(IRole role)
        {
            var statCollection = new StatCollection()
                                     {
                                        Strength = new StrengthStat(role.BaseStrength),
                                        Accuracy = new AccuracyStat(role.BaseAccuracy),
                                        Dodge = new DodgeStat(role.BaseDodge),
                                        Catch = new CatchStat(role.BaseCatch),
                                        Speed = new SpeedStat(role.BaseSpeed),
                                        Endurance = new EnduranceStat(role.BaseEndurance),
                                     };

            return statCollection;
        }
    }
}
