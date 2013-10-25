
namespace DodgeballGame.Roles
{
    public class ArcherRole : IRole
    {
        private const int _baseStrength = 6;
        private const int _baseSpeed = 3;
        private const int _baseAccuracy = 10;
        private const int _baseDodge = 4;
        private const int _baseCatch = 5;
        private const int _baseEndurance = 12;

        #region StatGetters
        public int BaseStrength
        {
            get { return _baseStrength; }
        }
        public int BaseSpeed
        {
            get { return _baseSpeed; }
        }
        public int BaseAccuracy
        {
            get { return _baseAccuracy; }
        }
        public int BaseDodge
        {
            get { return _baseDodge; }
        }
        public int BaseCatch
        {
            get { return _baseCatch; }
        }
        public int BaseEndurance
        {
            get { return _baseEndurance; }
        }
        #endregion
    }
}
