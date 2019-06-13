using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PONG
{
    public class Paddel : Spielobjekt, IPaddel
    {
        public Paddel() : this(0, 0, 0) { }


        public Paddel(int xMax, int yMax, SpielerPosition position)
        {
            // Höhe, breite und yMax setzen
            this.höhe = 200;
            this.breite = 20;
            this.yMax = yMax;
            this.position = position;

            // Position entsprechen des Spielers einstellen
            switch (position)
            {
                case SpielerPosition.Links:
                    this.XPos = breite;
                    this.YPos = yMax / 2 - this.höhe / 2;
                    break;
                case SpielerPosition.Rechts:
                    this.XPos = xMax - breite * 2;
                    this.YPos = yMax / 2 - this.höhe / 2;
                    break;
            }
        }

        private int höhe;
        private int breite;
        private int yMax;
        private SpielerPosition position;

        public void UpdatePos()
        {
            // Geschwindigkeit auf position addieren wenn das paddel nicht am rand ist
            if (this.YPos >= 0 && this.YVel < 0 || this.YPos + this.höhe <= yMax && this.YVel > 0)
                this.YPos += this.YVel;
        }

        public void Zeichnen(Graphics g) => g.FillRectangle(Brushes.White, new Rectangle((int)Math.Round(this.XPos), (int)Math.Round(this.YPos), this.breite, this.höhe));
        public void SetMov(PaddelBewegung mov)
        {
            // Geschwindigkeit entsprechend setzen
            switch (mov)
            {
                case PaddelBewegung.Hoch:
                    this.YVel = -5;
                    break;
                case PaddelBewegung.Runter:
                    this.YVel = 5;
                    break;
                case PaddelBewegung.Still:
                    this.YVel = 0;
                    break;
            }
        }

        public bool Kollidieren(float x, float y, int ballSize, out float angle)
        {
            angle = 0;
            if (this.YPos > y + ballSize || this.YPos + this.höhe < y)
            {
                return false;
            }

            // Verschiedene kollisions berechnungen je nach dem auf welcher seite das paddel ist
            switch (this.position)
            {
                case SpielerPosition.Links:
                    if (x <= this.XPos + this.breite)
                    {
                        angle = (float)(Math.PI / 2 - Math.Asin(this.YPos + (this.höhe / 2) - y + (ballSize / 2) / 2));
                        return true;
                    }
                    break;
                case SpielerPosition.Rechts:
                    if (x + ballSize >= this.XPos)
                    {
                        angle = (float)(Math.PI / 2 - Math.Asin(this.YPos + (this.höhe / 2) - y + (ballSize / 2) / 2));
                        return true;
                    }
                    break;
            }

            return false;
        }
    }
}