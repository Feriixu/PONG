using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PONG
{
    public class Ball : Spielobjekt
    {
        public Ball() : this(0, 0, 0)
        {

        }

        public Ball(int xMax, int yMax, int radius) : base(xMax, yMax)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get => Radius;
            set
            {
            }
        }

        public void Zeichnen(Graphics g)
        {
            throw new System.NotImplementedException();
        }
    }
}