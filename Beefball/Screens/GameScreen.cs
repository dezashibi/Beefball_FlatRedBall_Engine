using FlatRedBall.Input;

namespace GrinixDev.Screens
{
    public partial class GameScreen
    {
        private void CustomInitialize()
        {
            SetupInput();
        }

        private void SetupInput()
        {
            // PlayerBall1 refers to the entity we've defined in the editor

            if (InputManager.Xbox360GamePads[0].IsConnected)
            {
                PlayerBall1.MovementInput = InputManager.Xbox360GamePads[0].LeftStick;
                PlayerBall1.BoostInput = InputManager.Xbox360GamePads[0].GetButton(Xbox360GamePad.Button.A);
            }
            else
            {
                PlayerBall1.MovementInput = InputManager.Keyboard.Get2DInput(
                        Microsoft.Xna.Framework.Input.Keys.A,
                        Microsoft.Xna.Framework.Input.Keys.D,
                        Microsoft.Xna.Framework.Input.Keys.W,
                        Microsoft.Xna.Framework.Input.Keys.S
                    );
                PlayerBall1.BoostInput = InputManager.Keyboard.GetKey(Microsoft.Xna.Framework.Input.Keys.LeftShift);
            }
        }

        private void CustomActivity(bool firstTimeCalled)
        {

        }

        private void CustomDestroy()
        {

        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {

        }
    }
}
