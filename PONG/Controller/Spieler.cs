using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PONG
{
    public class Spieler
    {
        public Spieler()
        {
            throw new System.NotImplementedException();

            Paddel = new Paddel();
        }

        public Spieler(SpielerPosition position, int xMax, int yMax)
        {
            throw new System.NotImplementedException();
        }

        public Paddel Paddel
        {
            get => Paddel;
            set
            {
            }
        }

        public SpielerPosition SpielerPosition
        {
            get => SpielerPosition;
            set
            {
            }
        }

        public int Punkte
        {
            get => Punkte;
            set
            {
            }
        }

        public int Name
        {
            get => Name;
            set
            {
            }
        }
    }
}