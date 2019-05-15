using System;
using System.Drawing;
using System.Windows.Forms;

namespace PONG
{
    public partial class Spielfeld : Form
    {
        System.Timers.Timer timerGameTick, timerIncreaseSpeed;

        Graphics graphics;

        public Spielfeld()
        {
            InitializeComponent();
            gameArena.BackColor = Color.Black;
            graphics = gameArena.CreateGraphics();

            timerGameTick = new System.Timers.Timer() { Interval = 10 };
            timerIncreaseSpeed = new System.Timers.Timer() { Interval = 3000 };

            timerGameTick.Elapsed += timerGameTick_Tick;
            timerIncreaseSpeed.Elapsed += timerIncreaseSpeed_Tick;

            timerGameTick.Start();
            timerIncreaseSpeed.Start();
        }

        public PongGame PongGame
        {
            get => default;
            set
            {
            }
        }

        private void timerGameTick_Tick(object sender, EventArgs e)
        {
            PongGame.DrawIt(graphics);                      //Draws paddles & ball
            PongGame.MoveBall(timerGameTick);                  //Moves the ball
            PongGame.CheckScore();                      //Check if one player scored
            PongGame.CheckIfMoving();                   //Method that check if player is moving up or down the paddle
        }

        private void Spielfeld_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.S)
            { PongGame.p1movesDown = true; }
            if (e.KeyData == Keys.W)
            { PongGame.p1movesUp = true; }
            if (e.KeyData == Keys.L)
            { PongGame.p2movesDown = true; }
            if (e.KeyData == Keys.P)
            { PongGame.p2movesUp = true; }
        }

        private void Spielfeld_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.S)
            { PongGame.p1movesDown = false; }
            if (e.KeyData == Keys.W)
            { PongGame.p1movesUp = false; }
            if (e.KeyData == Keys.L)
            { PongGame.p2movesDown = false; }
            if (e.KeyData == Keys.P)
            { PongGame.p2movesUp = false; }
        }

        private void timerIncreaseSpeed_Tick(object sender, EventArgs e)
        { PongGame.IncreaseSpeed(); }     //Every 3 seconds, this timer will increase Overall speed
    }
}

