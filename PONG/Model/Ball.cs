using System;
using System.Drawing;

namespace PONG
{
    public class Ball : Spielobjekt, IBall
    {
        public Ball() : this(0, 0, 0) { }

        public Ball(Size size, int radius) : this(size.Width, size.Height, radius) { }

        public Ball(int xMax, int yMax, int radius) : base(xMax, yMax)
        {
            this.Size = radius;
            this.xMax = xMax;
            this.yMax = yMax;
            Random r = new Random();

            this.XVel = r.Next(0, 2) == 0 ? -3 : 3;
            this.YVel = 0;
        }

        private int Size;
        private int xMax;
        private int yMax;
        private ISpieler spieler1;
        private ISpieler spieler2;

        public void SetSpieler(ISpieler spieler1, ISpieler spieler2)
        {
            this.spieler1 = spieler1;
            this.spieler2 = spieler2;
        }

        public int UpdatePos()
        {
            // Kollision abfragen und reflektieren
            if (this.XPos < 0 || this.XPos + this.Size > this.xMax)
                return ((this.XPos < 0) ? 1 : -1);
            if (this.YPos < 0 || this.YPos + this.Size > this.yMax)
                this.YVel *= -1;

            // Kollision mit Spieler abfragen
            bool result1 = spieler1.Paddel.Kollidieren(this.XPos, this.YPos, this.Size, out var angle1);
            if (result1)
            {
                this.XVel *= -1;
                Random r = new Random();
                this.YVel += (float)r.NextDouble() - 0.5F;
            }

            bool result2 = spieler2.Paddel.Kollidieren(this.XPos, this.YPos, this.Size,  out var angle2);
            if (result2)
            {
                this.XVel *= -1;
                Random r = new Random();
                this.YVel += (float)r.NextDouble() - 0.5F;
            }

            this.XPos += this.XVel;
            this.YPos += this.YVel;

            return 0;
        }

        public void Zeichnen(Graphics g) => g.FillRectangle(Brushes.White, this.XPos, this.YPos, this.Size, this.Size);
        public void IncreaseSpeed()
        {
            this.XVel *= 1.2F;
            this.YVel *= 1.2F;
        }

        public void Reset()
        {
            this.XPos = xMax / 2;
            this.YPos = yMax / 2;

            Random r = new Random();

            this.XVel = r.Next(0, 2) == 0 ? -3 : 3;
            this.YVel = 0;

        }
    }
}