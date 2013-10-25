
namespace DodgeballGame.Roles
{
    public class WizardRole : IRole
    {
        private const int _baseStrength = 5;
        private const int _baseSpeed = 2;
        private const int _baseAccuracy = 7;
        private const int _baseDodge = 5;
        private const int _baseCatch = 7;
        private const int _baseEndurance = 16;

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
