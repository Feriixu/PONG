using System.Drawing;

namespace PONG
{
    public interface ISpieler
    {
        string Name { get; }
        int Punkte { get; }

        void Zeichnen(Graphics g);
        void UpdatePos();
        void SetMov(PaddelBewegung mov);
    }
}