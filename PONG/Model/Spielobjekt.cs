using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PONG
{
    public class Spielobjekt
    {
        public Spielobjekt() : this(0, 0, 0, 0)
        {
            
        }

        public Spielobjekt(int xPos, int yPos, float xVel, float yVel)
        {
            this.XPos = xPos;
            this.YPos = yPos;
            this.XVel = xVel;
            this.YVel = yVel;     
        }

        public Spielobjekt(int xMax, int yMax) : this(xMax / 2, yMax / 2, 0, 0)
        {
        }

        protected float XPos;
        protected float YPos;
        protected float XVel;
        protected float YVel;
    }
}