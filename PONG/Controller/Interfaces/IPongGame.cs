using System;

namespace PONG
{
    public interface IPongGame
    {
        event EventHandler SpielVorbei;

        void OnSpielVorbei(EventArgs e);
        void SpielerInput(SpielerPosition spieler, PaddelBewegung richtung);
        void StartGame();
    }
}