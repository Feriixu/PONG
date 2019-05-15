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

        public Spieler(SpielerPosition position)
        {
            throw new System.NotImplementedException();
        }

        public Paddel Paddel
        {
            get => default;
            set
            {
            }
        }

        public SpielerPosition SpielerPosition
        {
            get => default;
            set
            {
            }
        }

        public int Punkte
        {
            get => default;
            set
            {
            }
        }

        public int Name
        {
            get => default;
            set
            {
            }
        }
    }
}