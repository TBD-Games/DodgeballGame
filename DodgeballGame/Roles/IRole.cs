
namespace DodgeballGame.Roles
{
    public interface IRole
    {
        int BaseStrength { get; }
        int BaseSpeed { get; }
        int BaseAccuracy { get; }
        int BaseDodge { get; }
        int BaseCatch { get; }
        int BaseEndurance { get; }
    }
}
