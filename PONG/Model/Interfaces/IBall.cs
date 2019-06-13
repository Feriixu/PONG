using System.Drawing;

namespace PONG
{
    public interface IBall
    {
        void IncreaseSpeed();
        void SetSpieler(ISpieler spieler1, ISpieler spieler2);
        int UpdatePos();
        void Zeichnen(Graphics g);
        void Reset();
    }
}