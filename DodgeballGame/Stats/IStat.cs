
namespace DodgeballGame.Stats
{
    public interface IStat
    {
        string DisplayName { get; }
        int BaseValue { get; }
        int CurrentValue { get; set; }
        int Min { get; }
    }
}
