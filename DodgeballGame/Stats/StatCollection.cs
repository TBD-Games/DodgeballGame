
namespace DodgeballGame.Stats
{
    public interface IStatCollection
    {
        IStrengthStat Strength { get; set; }
        IAccuracyStat Accuracy { get; set; }
        IDodgeStat Dodge { get; set; }
        ICatchStat Catch { get; set; }
        ISpeedStat Speed { get; set; }
        IEnduranceStat Endurance { get; set; }
    }

    public class StatCollection : IStatCollection
    {
        public IStrengthStat Strength { get; set; }
        public IAccuracyStat Accuracy { get; set; }
        public IDodgeStat Dodge { get; set; }
        public ICatchStat Catch { get; set; }
        public ISpeedStat Speed { get; set; }
        public IEnduranceStat Endurance { get; set; }
    }
}
