using System.Drawing;

namespace PONG
{
    public interface IPaddel
    {
        void UpdatePos();
        void Zeichnen(Graphics g);
        void SetMov(PaddelBewegung mov);
<<<<<<< HEAD
=======
        void Kollidieren(int x, int y);
>>>>>>> 290b9384962e75e077b2e1e2650e13c8260c7967
    }
}