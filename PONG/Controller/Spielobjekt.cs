using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PONG
{
    public class Spielobjekt
    {
        internal Spielobjekt(int xPos, int yPos, float xVel, float yVel)
        {
            this.XPos = xPos;
            this.YPos = yPos;
            this.XVel = xVel;
            this.YVel = yVel;
        }

        public int XPos
        {
            get => default;
            set
            {
            }
        }

        public int YPos
        {
            get => default;
            set
            {
            }
        }

        public float XVel
        {
            get => default;
            set
            {
            }
        }

        public float YVel
        {
            get => default;
            set
            {
            }
        }

        public void Update()
        {
            this.XPos = Convert.ToInt32(this.XPos + this.XVel);
            this.YPos = Convert.ToInt32(this.YPos + this.YVel);
        }
    }
}