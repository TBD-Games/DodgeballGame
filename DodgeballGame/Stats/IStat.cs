
namespace DodgeballGame.Stats
{
    public interface IStat
    {
        string DisplayName { get; }
        int Value { get; set; }
        int Min { get; }
    }
}
