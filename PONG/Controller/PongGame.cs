using System;
using System.Drawing;
using System.Timers;

namespace PONG
{
    public class PongGame
    {
        //public static Rectangle paddle1 = new Rectangle(14, 180, 20, 100);
        //public static Rectangle paddle2 = new Rectangle(566, 180, 20, 100);
        //public static Rectangle ball = new Rectangle(290, 115, 16, 16);
        Font Drawfont = new Font("Arial", 40);
        public static SolidBrush Brush = new SolidBrush(Color.White);
        private int timerGameTick;

        //public static double p1p;                           //Double that will store player 1 score
        //public static double p2p;                           //Double that will store player 2 score

        public Ball Ball
        {
            get => default;
            set
            {
            }
        }

        public Spieler Spieler1
        {
            get => default;
            set
            {
            }
        }

        public Spieler Spieler2
        {
            get => default;
            set
            {
            }
        }

        public static void DrawIt(Graphics Draw)
        {   //Draws both paddles and ball
            Draw.Clear(Color.Black);
            Draw.FillRectangle(Brush, paddle2);
            Draw.FillRectangle(Brush, Paddel1);
            Draw.FillRectangle(Brush, ball);
            //Draw Score
            Draw.DrawString(p1p.ToString(), Drawfont, Brush, 180, 10);
            Draw.DrawString(p2p.ToString(), Drawfont, Brush, 380, 10);
        }

        public void CheckIfMoving()                      //If player press the key to move the paddle, this method
        {                                                       //changes the Y position of the paddle Accordingly
            if (p1movesUp == true)
            { int z = Paddel1.YPos <= 0 ? Paddel1.YPos = 0 : Paddel1.YPos -= 3; }
            if (p1movesDown == true)
            { int z = Paddel1.YPos >= 381 ? Paddel1.YPos = 381 : Paddel1.YPos += 3; }
            if (p2movesUp == true)
            { int z = Paddel2.YPos <= 0 ? Paddel2.YPos = 0 : Paddel2.YPos -= 3; }
            if (p2movesDown == true)
            { int z = Paddel2.YPos >= 381 ? Paddel2.YPos = 381 : Paddel2.YPos += 3; }
        }

        public void Restart()                            //Method called upon player scoring, to reset speed values
        {                                                       //and ball position
            Ball.XPos = 290; Ball.YVel = 1;
            Ball.YPos = 115; Ball.XVel = -1;
        }

        public static void CheckScore()                         //Check if any player has scored, and increase p1p accordingly
        {
            if (ball.X < 1)
            { p2p += 1; Restart(); }
            else if (ball.X > 579)
            { p1p += 1; Restart(); }
        }

        public static void IncreaseSpeed()                      //Increase both the normal speed and the results of
        {                                                       //any possible randomization in the Randomize() method
            RandoMin += 1;
            RandoMax += 1;
            Xspeed = Xspeed < 0 ? Xspeed -= 1 : Xspeed += 1;
        }

        public static void MoveBall(Timer t1)
        {
            ball.X += (int)Xspeed;                                     //Changes ball coordinates based on speed in both x & y axis
            ball.Y += (int)Yspeed;
            if (ball.Y > 465 || ball.Y < 0) { Yspeed = -Yspeed; }     //If ball touch one of the Y bounds, it's y speed gets a change in sign, and ball rebounce
            if (ball.X > 579 || ball.X < 1) { Xspeed = -Xspeed; }     //Same for X bounds, with x speed
            if (ball.IntersectsWith(paddle1) || ball.IntersectsWith(paddle2))
            {
                int dst = paddle1.Y + 100;
                int Distance = dst - ball.Y;
                if (Distance > 75 || Distance < 25) { Randomize(); }  //If the ball intersects the paddle "away" from the centre, the ball movement get randomized
                else { Xspeed = -Xspeed; }                             //else, it's speed on the X axis gets simply reverted
            }
        }

        static void Randomize()
        {
            Random r = new Random();

            double s = r.Next(RandoMin, RandoMax);                     //Uses RandoMin & RandoMax values to randomize the X speed of the ball
            Xspeed = ball.IntersectsWith(paddle1) ? Xspeed = s : Xspeed = -s;

            if (Yspeed < 0)                                            //If ball is moving upward, (so y speed is negative) the random value assigned
            {                                                          //will be changed in sign, so the ball can still go upward
                double t = r.Next(RandoMin, RandoMax);
                Yspeed = -t;
            }
            else                                                       //Else, directly change the Y speed to a positive value
            { Yspeed = r.Next(RandoMin, RandoMax); }
        }
    }
}
