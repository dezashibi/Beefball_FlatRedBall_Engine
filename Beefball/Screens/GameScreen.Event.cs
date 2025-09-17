namespace GrinixDev.Screens
{
    public partial class GameScreen
    {
        void OnPuckVsGoalCollided(Entities.Puck puck, Entities.Goal goal)
        {
            if (goal == LeftGoal)
            {
                _player2Score++;
                ReactToNewScore();
            }
            else if (goal == RightGoal)
            {
                _player1Score++;
                ReactToNewScore();
            }
        }

        private void ReactToNewScore()
        {
            PlayerBall1.X = -180;
            PlayerBall1.Y = 0;
            PlayerBall1.Velocity = Microsoft.Xna.Framework.Vector3.Zero;
            PlayerBall1.Acceleration = Microsoft.Xna.Framework.Vector3.Zero;

            PlayerBall2.X = 180;
            PlayerBall2.Y = 0;
            PlayerBall2.Velocity = Microsoft.Xna.Framework.Vector3.Zero;
            PlayerBall2.Acceleration = Microsoft.Xna.Framework.Vector3.Zero;

            Puck1.X = 0;
            Puck1.Y = 0;
            Puck1.Velocity = Microsoft.Xna.Framework.Vector3.Zero;
        }
    }
}
