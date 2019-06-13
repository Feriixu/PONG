using System.Drawing;

namespace PONG
{
    public interface IPaddel
    {
        void UpdatePos();
        void Zeichnen(Graphics g);
        void SetMov(PaddelBewegung mov);
        float Kollidieren(float x, float y, int ballSize);
    }
}