using System.Drawing;

namespace PONG
{
    public interface ISpieler
    {
        string Name { get; }
        IPaddel Paddel { get; }
        int Punkte { get; }

        void SetMov(PaddelBewegung mov);
        void UpdatePos();
        void Zeichnen(Graphics g);
    }
}