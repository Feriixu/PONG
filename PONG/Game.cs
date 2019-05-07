using System;
using System.Drawing;
using System.Windows.Forms;

namespace PONG
{
    public partial class Game : Form
    {
        System.Timers.Timer timer1, timer2;

        Graphics Draw;
        SolidBrush sb = new SolidBrush(Color.White);
        public Game()
        {
            InitializeComponent();
            gameArena.BackColor = Color.Black;
            Draw = gameArena.CreateGraphics();

            timer1 = new System.Timers.Timer() { Interval = 10 };
            timer2 = new System.Timers.Timer() { Interval = 3000 };

            timer1.Elapsed += timer1_Tick;
            timer2.Elapsed += timer2_Tick;

            timer1.Start();
            timer2.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            PongGame.DrawIt(Draw);                      //Draws paddles & ball
            PongGame.MoveBall(timer1);                  //Moves the ball
            PongGame.CheckScore();                      //Check if one player scored
            PongGame.CheckIfMoving();                   //Method that check if player is moving up or down the paddle
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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

        private void timer2_Tick(object sender, EventArgs e)
        { PongGame.IncreaseSpeed(); }     //Every 3 seconds, this timer will increase Overall speed
    }
}

