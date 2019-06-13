using System;
using System.Drawing;
using System.Windows.Forms;

namespace PONG
{
    public partial class Spielfeld : Form, ISpielfeld
    {
        private Spielermodus spielermodus;
        private ISpieler spieler1;
        private ISpieler spieler2;

        public Spielfeld(Spielermodus spielermodus)
        {
            InitializeComponent();
            pictureBoxSpielfeld.BackColor = Color.Black;
            this.spielermodus = spielermodus;
        }

        public void ShowGame()
        {
            // Spielfeld anzeigen
            this.Show();
        }

        private void Spielfeld_KeyDown(object sender, KeyEventArgs e)
        {
            // Gedrückte Taste überprüfen
            switch (e.KeyData)
            {
                case Keys.W:
                    spieler1.SetMov(PaddelBewegung.Hoch);
                    break;
                case Keys.S:
                    spieler1.SetMov(PaddelBewegung.Runter);
                    break;
                case Keys.Up:
                    spieler2.SetMov(PaddelBewegung.Hoch);
                    break;
                case Keys.Down:
                    spieler2.SetMov(PaddelBewegung.Runter);
                    break;
            }
        }

        private void Spielfeld_KeyUp(object sender, KeyEventArgs e)
        {
            // Losgelassene Taste überprüfen
            switch (e.KeyData)
            {
                case Keys.S:
                    spieler1.SetMov(PaddelBewegung.Still);
                    break;
                case Keys.W:
                    spieler1.SetMov(PaddelBewegung.Still);
                    break;
                case Keys.Up:
                    spieler2.SetMov(PaddelBewegung.Still);
                    break;
                case Keys.Down:
                    spieler2.SetMov(PaddelBewegung.Still);
                    break;
            }
        }

        public void SpielVorbei_Trigger(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public Graphics GetGraphics() => this.pictureBoxSpielfeld.CreateGraphics();
        public void SetSpieler(ISpieler spieler1, ISpieler spieler2)
        {
            if (spieler1 == null)
                throw new ArgumentNullException(nameof(spieler1));
            if (spieler2 == null)
                throw new ArgumentNullException(nameof(spieler2));
            this.spieler1 = spieler1;
            this.spieler2 = spieler2;
        }

        public PictureBox PictureBox => this.pictureBoxSpielfeld;
    }
}

