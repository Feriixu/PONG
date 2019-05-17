using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PONG
{
    public class Paddel : Spielobjekt
    {
        public Paddel()
        {
            throw new System.NotImplementedException();
        }

        public Paddel(int xMax, int yMax, SpielerPosition position)
        {
            throw new System.NotImplementedException();
        }


        public bool Links
        {
            get => Links;
            set
            {
                if (value)
                    Links = value;
            }
        }

        public int Breite
        {
            get => Breite;
            set
            {
            }
        }

        public int Höhe
        {
            get => Höhe;
            set
            {
            }
        }

        public new void Update()
        {
            throw new System.NotImplementedException();
        }

        public void Zeichnen(Graphics g)
        {
            throw new System.NotImplementedException();
        }
    }
}