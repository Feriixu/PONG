using System;
using System.Drawing;

namespace PONG
{
    public class PongGame : IPongGame
    {
        private readonly System.Windows.Forms.Timer timerGameTick;
        private readonly System.Windows.Forms.Timer timerIncreaseSpeed;
        private readonly ISpielfeld spielfeld;
        private readonly Graphics graphics;

        public event EventHandler SpielVorbei;

        public PongGame(Spielermodus spielermodus, Punktemodus punktemodus)
        {
            // Modus werte speichern
            this.spielermodus = spielermodus;
            this.punktemodus = punktemodus;

            // Erzeuge neues spielfeld
            this.spielfeld = new Spielfeld(spielermodus);

            // Zeige das Spielfeld
            this.spielfeld.ShowGame();

            // Hole graphics
            this.graphics = this.spielfeld.GetGraphics();

            // Erzeuge ball und zeichne
            this.ball = new Ball(this.spielfeld.PictureBox.Size, 20);
            this.ball.Zeichnen(this.graphics);

            // Erzeuge spieler und zeichne
            this.spieler1 = new Spieler(SpielerPosition.Links, this.spielfeld.PictureBox.Size, "Spieler 1");
            this.spieler1.Zeichnen(this.graphics);
            this.spieler2 = new Spieler(SpielerPosition.Rechts, this.spielfeld.PictureBox.Size, "Spieler 2");
            this.spieler2.Zeichnen(this.graphics);

            // Übergebe dem Spielfeld die Spieler objekte damit es die Bewegung anpassen kann
            this.spielfeld.SetSpieler(spieler1, spieler2);
            // Übergebe dem Ball die Spieler damit er die kollision abfragen kann
            this.ball.SetSpieler(spieler1, spieler2);

            // Stelle die timer ein
            // GameTick Timer
            this.timerGameTick = new System.Windows.Forms.Timer()
            { Interval = 10 };
            this.timerGameTick.Tick += this.timerGameTick_Tick;
            // Geschwindigkeit erhöhen timer
            this.timerIncreaseSpeed = new System.Windows.Forms.Timer()
            { Interval = 10000 };
            this.timerIncreaseSpeed.Tick += this.TimerIncreaseSpeedTick_Tick;
        }

        private readonly IBall ball;
        private readonly ISpieler spieler1;
        private readonly ISpieler spieler2;
        private readonly Punktemodus punktemodus;
        private readonly Spielermodus spielermodus;

        private void Reset() => throw new System.NotImplementedException();//and ball position

        private void PunktestandPrüfen() => throw new NotImplementedException();

        public void SpielerInput(SpielerPosition spieler, PaddelBewegung richtung) => throw new System.NotImplementedException();

        private void timerGameTick_Tick(object sender, EventArgs e)
        {
            // Positionen Updaten
            var playerWon = this.ball.UpdatePos();
            switch (playerWon)
            {
                case -1:
                    spieler1.AddPunkt();
                    ball.Reset();
                    break;
                case 1:
                    spieler2.AddPunkt();
                    ball.Reset();
                    break;
            }
            this.spieler1.UpdatePos();
            this.spieler2.UpdatePos();

            // Alles zeichnen
            this.graphics.Clear(Color.Black);
            this.ball.Zeichnen(this.graphics);
            this.spieler1.Zeichnen(this.graphics);
            this.spieler2.Zeichnen(this.graphics);

            //this.PunktestandPrüfen();
        }

        private void TimerIncreaseSpeedTick_Tick(object sender, EventArgs e)
        {
            this.ball.IncreaseSpeed();
        }

        public void OnSpielVorbei(EventArgs e)
        {
            // Stoppe die Timer
            this.timerGameTick.Stop();
            this.timerIncreaseSpeed.Stop();

            throw new NotImplementedException();
        }

        public void StartGame()
        {
            // Starte die Timer
            this.timerGameTick.Start();
            this.timerIncreaseSpeed.Start();
        }
    }
}
