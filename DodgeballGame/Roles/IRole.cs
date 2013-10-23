
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

        int CurrentStrength { get; set; }
        int CurrentSpeed { get; set; }
        int CurrentAccuracy { get; set; }
        int CurrentDodge { get; set; }
        int CurrentCatch { get; set; }
        int CurrentEndurance { get; set; }
    }
}
