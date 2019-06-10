using System.Drawing;

namespace PONG
{
    public interface IBall
    {
        void IncreaseSpeed();
        void SetSpieler(ISpieler spieler1, ISpieler spieler2);
        void UpdatePos();
        void Zeichnen(Graphics g);
    }
}