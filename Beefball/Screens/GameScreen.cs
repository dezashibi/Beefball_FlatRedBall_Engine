﻿using FlatRedBall.Input;

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
            // PlayerBall1 and Player2 refer to the objects from entities we've added to the screen in the editor

            /* Player 1 Controller */
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

            /* Player 2 Controller */
            if (InputManager.Xbox360GamePads[1].IsConnected)
            {
                PlayerBall2.MovementInput = InputManager.Xbox360GamePads[1].LeftStick;
                PlayerBall2.BoostInput = InputManager.Xbox360GamePads[1].GetButton(Xbox360GamePad.Button.A);
            }
            else
            {
                PlayerBall2.MovementInput = InputManager.Keyboard.Get2DInput(
                        Microsoft.Xna.Framework.Input.Keys.Left,
                        Microsoft.Xna.Framework.Input.Keys.Right,
                        Microsoft.Xna.Framework.Input.Keys.Up,
                        Microsoft.Xna.Framework.Input.Keys.Down
                    );
                PlayerBall2.BoostInput = InputManager.Keyboard.GetKey(Microsoft.Xna.Framework.Input.Keys.RightShift);
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
