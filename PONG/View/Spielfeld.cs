using System;
using System.Drawing;
using System.Windows.Forms;

namespace PONG
{
    public partial class Spielfeld : Form
    {
        public Spielfeld(Punktemodus modus, bool ki)
        {
            InitializeComponent();
            pictureBoxSpielfeld.BackColor = Color.Black;
        }

        public PongGame PongGame
        {
            get => PongGame;
            set
            {
            }
        }

        private void Spielfeld_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.S:
                    break;
                case Keys.W:
                    break;
                case Keys.Up:
                    break;
                case Keys.Down:
                    break;
            }
        }

        private void Spielfeld_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.S:
                    break;
                case Keys.W:
                    break;
                case Keys.Up:
                    break;
                case Keys.Down:
                    break;
            }
        }

        public void SpielVorbei_Trigger(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}

