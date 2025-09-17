using FlatRedBall.Input;

namespace GrinixDev.Entities
{
    public partial class PlayerBall
    {
        public I2DInput MovementInput { get; set; }
        public IPressableInput BoostInput { get; set; }

        /// <summary>
        /// Initialization logic which is executed only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
        private void CustomInitialize()
        {

        }

        private void CustomActivity()
        {
            if (MovementInput != null)
            {
                XVelocity = MovementInput.X * MovementSpeed;
                YVelocity = MovementInput.Y * MovementSpeed;
            }
        }

        private void CustomDestroy()
        {

        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {

        }
    }
}
