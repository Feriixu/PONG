using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace PONG
{
    public class PongGame
    {
        //public static Rectangle paddle1 = new Rectangle(14, 180, 20, 100);
        //public static Rectangle paddle2 = new Rectangle(566, 180, 20, 100);
        //public static Rectangle ball = new Rectangle(290, 115, 16, 16);
        Font Drawfont = new Font("Arial", 40);
        private static SolidBrush Brush = new SolidBrush(Color.White);
        private System.Windows.Forms.Timer timerGameTick;
        private System.Windows.Forms.Timer timerIncreaseSpeed;
        private bool ki;
        private PictureBox spielfeld;

        public event EventHandler SpielVorbei;

        public PongGame(Punktemodus modus, bool ki, PictureBox spielfeld)
        {
            throw new System.NotImplementedException();
        }

        //public static double p1p;                           //Double that will store player 1 score
        //public static double p2p;                           //Double that will store player 2 score

        private Ball Ball
        {
            get => Ball;
            set
            {
            }
        }

        private Spieler Spieler1
        {
            get => Spieler1;
            set
            {
            }
        }

        private Spieler Spieler2
        {
            get => Spieler2;
            set
            {
            }
        }

        private PaddelBewegung PaddelBewegung1
        {
            get => PaddelBewegung1;
            set
            {
            }
        }

        private PaddelBewegung PaddelBewegung2
        {
            get => PaddelBewegung2;
            set
            {
            }
        }

        private Punktemodus Punktemodus
        {
            get => Punktemodus;
            set
            {
            }
        }

        public Spielermodus Spielermodus
        {
            get => default;
            set
            {
            }
        }

        //private static void DrawIt(Graphics Draw)
        //{
        //    throw new System.NotImplementedException();

        //    //Draws both paddles and ball
        //    Draw.Clear(Color.Black);
        //    Draw.FillRectangle(Brush, paddle2);
        //    Draw.FillRectangle(Brush, Paddel1);
        //    Draw.FillRectangle(Brush, ball);
        //    //Draw Score
        //    Draw.DrawString(p1p.ToString(), Drawfont, Brush, 180, 10);
        //    Draw.DrawString(p2p.ToString(), Drawfont, Brush, 380, 10);
        //}

        private void Reset()
        {
            throw new System.NotImplementedException();

            //and ball position
            Ball.XPos = 290; Ball.YVel = 1;
            Ball.YPos = 115; Ball.XVel = -1;
        }

        private void PunktestandPrüfen()                         //Check if any player has scored, and increase p1p accordingly
        {
            throw new System.NotImplementedException();
        }

        //private void IncreaseSpeed()
        //{
        //    throw new System.NotImplementedException();

        //    //any possible randomization in the Randomize() method
        //    RandoMin += 1;
        //    RandoMax += 1;
        //    Xspeed = Xspeed < 0 ? Xspeed -= 1 : Xspeed += 1;
        //}

        //private void MoveBall(Timer t1)
        //{
        //    throw new System.NotImplementedException();

        //    ball.X += (int)Xspeed;                                     //Changes ball coordinates based on speed in both x & y axis
        //    ball.Y += (int)Yspeed;
        //    if (ball.Y > 465 || ball.Y < 0) { Yspeed = -Yspeed; }     //If ball touch one of the Y bounds, it's y speed gets a change in sign, and ball rebounce
        //    if (ball.X > 579 || ball.X < 1) { Xspeed = -Xspeed; }     //Same for X bounds, with x speed
        //    if (ball.IntersectsWith(paddle1) || ball.IntersectsWith(paddle2))
        //    {
        //        int dst = paddle1.Y + 100;
        //        int Distance = dst - ball.Y;
        //        if (Distance > 75 || Distance < 25) { Randomize(); }  //If the ball intersects the paddle "away" from the centre, the ball movement get randomized
        //        else { Xspeed = -Xspeed; }                             //else, it's speed on the X axis gets simply reverted
        //    }
        //}

        //static void Randomize()
        //{
        //    throw new System.NotImplementedException();

        //    Random r = new Random();

        //    double s = r.Next(RandoMin, RandoMax);                     //Uses RandoMin & RandoMax values to randomize the X speed of the ball
        //    Xspeed = ball.IntersectsWith(paddle1) ? Xspeed = s : Xspeed = -s;

        //    if (Yspeed < 0)                                            //If ball is moving upward, (so y speed is negative) the random value assigned
        //    {                                                          //will be changed in sign, so the ball can still go upward
        //        double t = r.Next(RandoMin, RandoMax);
        //        Yspeed = -t;
        //    }
        //    else                                                       //Else, directly change the Y speed to a positive value
        //    { Yspeed = r.Next(RandoMin, RandoMax); }
        //}

        public void SpielerInput(SpielerPosition spieler, PaddelBewegung richtung)
        {
            throw new System.NotImplementedException();
        }

        public void timerGameTick_Tick()
        {
            throw new System.NotImplementedException();
        }

        public void timerIncreaseSpeedTick_Tick()
        {
            Ball.Update();
            throw new System.NotImplementedException();
        }

        public void OnSpielVorbei(EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
