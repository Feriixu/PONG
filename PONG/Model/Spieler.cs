using System.Drawing;

namespace PONG
{
    public class Spieler : ISpieler
    {
        public IPaddel Paddel => this.paddel;
        private readonly IPaddel paddel;

        public int Punkte => this.punkte;
        private readonly int punkte;

        public string Name { get; }
        private readonly string name;

        private PointF scorePosition;

        public Spieler(SpielerPosition spielerposition, int xMax, int yMax, string name)
        {
            // Erzeuge neues Paddel für den Spieler
            this.paddel = new Paddel(xMax, yMax, spielerposition);
            // Setze Punkte auf startwert
            this.punkte = 0;
            // Setze den Namen
            this.name = name;
            // Speichere spielerposition
            switch (spielerposition)
            {
                case SpielerPosition.Links:
                    this.scorePosition = new PointF(xMax / 2 - 50, 30);
                    break;
                case SpielerPosition.Rechts:
                    this.scorePosition = new PointF(xMax / 2 + 50, 30);
                    break;
            }
        }

        public Spieler(SpielerPosition spielerposition, Size size, string name) : this(spielerposition, size.Width, size.Height, name) { }

        public void UpdatePos() =>
            // Update die Position des paddels
            this.paddel.UpdatePos();

        public void Zeichnen(Graphics g)
        {
            // Zeichne das Paddel
            this.paddel.Zeichnen(g);
            var f = new Font("Agency FB", 30.0F);
            g.DrawString(this.punkte.ToString(), f, Brushes.White, this.scorePosition, new StringFormat() { Alignment = StringAlignment.Center });
        }

        public void SetMov(PaddelBewegung mov) =>
            // Setze vel für das Paddel
            this.paddel.SetMov(mov);
    }
}