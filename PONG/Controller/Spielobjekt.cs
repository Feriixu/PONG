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

        public int XPos
        {
            get => XPos;
            set
            {
            }
        }

        public int YPos
        {
            get => YPos;
            set
            {
            }
        }

        public float XVel
        {
            get => XVel;
            set
            {
            }
        }

        public float YVel
        {
            get => YVel;
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