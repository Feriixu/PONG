using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PONG
{
    public class Ball : Spielobjekt
    {
        public Ball(int xPos, int yPos, float xVel, float yVel, int radius) : base(xPos, yPos, xVel, yVel)
        {
            this.Radius = radius;
        }

        public Ball() : this(0, 0, 0, 0, 0)
        {

        }

        public int Radius
        {
            get => default;
            set
            {
            }
        }
    }
}