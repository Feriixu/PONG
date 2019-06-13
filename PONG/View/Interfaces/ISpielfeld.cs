using System;
using System.Drawing;
using System.Windows.Forms;

namespace PONG
{
    public interface ISpielfeld
    {
        void SpielVorbei_Trigger(object sender, EventArgs e);
        void ShowGame();
        Graphics GetGraphics();
        PictureBox PictureBox { get; }

        void SetSpieler(ISpieler spieler1, ISpieler spieler2);
    }
}