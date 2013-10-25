
namespace DodgeballGame.Roles
{
    public class ThiefRole : IRole
    {
        private const int _baseStrength = 8;
        private const int _baseSpeed = 5;
        private const int _baseAccuracy = 2;
        private const int _baseDodge = 10;
        private const int _baseCatch = 3;
        private const int _baseEndurance = 25;

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
