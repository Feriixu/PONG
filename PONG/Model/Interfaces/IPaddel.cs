﻿using System.Drawing;

namespace PONG
{
    public interface IPaddel
    {
        void UpdatePos();
        void Zeichnen(Graphics g);
        void SetMov(PaddelBewegung mov);
    }
}