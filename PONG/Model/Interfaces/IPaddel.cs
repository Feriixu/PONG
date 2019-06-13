using System.Drawing;

namespace PONG
{
    public interface IPaddel
    {
        bool Kollidieren(float x, float y, int ballSize, out float angle);
        void SetMov(PaddelBewegung mov);
        void UpdatePos();
        void Zeichnen(Graphics g);
    }
}