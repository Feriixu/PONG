using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONG
{
    public partial class MainMenu : Form, IMainMenu
    {
        private bool endlos;
        private SoundPlayer menuClick;

        #region Fenster and jeder Stelle ziehen
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainMenu_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        public MainMenu()
        {
            InitializeComponent();
            endlos = false;
            menuClick = new SoundPlayer(Properties.Resources.menuClick);
        }

        public void ShowMenu()
        {
            this.ShowDialog();
        }

        private void PictureBoxEinzelspieler_Click(object sender, EventArgs e)
        {
            this.Hide();
            var eventArgs = new StartGameEventArgs(Spielermodus.Einzelspieler, endlos ? Punktemodus.Endlos : Punktemodus.Punkte);
            StartEinzelspieler?.Invoke(this, eventArgs);
        }

        private void PictureBoxMehrspieler_Click(object sender, EventArgs e)
        {
            this.Hide();
            var eventArgs = new StartGameEventArgs(Spielermodus.Mehrspieler, endlos ? Punktemodus.Endlos : Punktemodus.Punkte);
            StartMehrspieler?.Invoke(this, eventArgs);
        }

        private void PictureBoxEinzelspieler_MouseEnter(object sender, EventArgs e)
        {
            menuClick.Play();
            ((PictureBox)sender).BackgroundImage = Properties.Resources.einzel;
        }

        private void PictureBoxEinzelspieler_MouseLeave(object sender, EventArgs e) => ((PictureBox)sender).BackgroundImage = Properties.Resources.einzelDisabled;

        private void PictureBoxMehrspieler_MouseEnter(object sender, EventArgs e)
        {
            menuClick.Play();
            ((PictureBox)sender).BackgroundImage = Properties.Resources.mehr;
        }

        private void PictureBoxMehrspieler_MouseLeave(object sender, EventArgs e) => ((PictureBox)sender).BackgroundImage = Properties.Resources.mehrDisabled;

        private void PictureBoxEndlos_Click(object sender, EventArgs e)
        {
            if (!endlos) menuClick.Play();
            endlos = true;
            pictureBoxEndlos.BackgroundImage = Properties.Resources.endlos;
            pictureBoxPunkte.BackgroundImage = Properties.Resources.punkteDisabled;
        }

        private void PictureBoxPunkte_Click(object sender, EventArgs e)
        {
            if (endlos) menuClick.Play();
            endlos = false;
            pictureBoxPunkte.BackgroundImage = Properties.Resources.punkte;
            pictureBoxEndlos.BackgroundImage = Properties.Resources.endlosDisabled;
        }

        private void PictureBoxXButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxXButton_MouseEnter(object sender, EventArgs e)
        {
            menuClick.Play();
            ((PictureBox)sender).BackgroundImage = Properties.Resources.xButton;
        }

        private void PictureBoxXButton_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.xButtonDisabled;
        }

        public event StartGameEventHandler StartEinzelspieler;
        public event StartGameEventHandler StartMehrspieler;
    }

    public class StartGameEventArgs : EventArgs
    {
        public StartGameEventArgs(Spielermodus sM, Punktemodus pM)
        {
            Spielermodus = sM;
            Punktemodus = pM;
        }

        public Punktemodus Punktemodus { get; }
        public Spielermodus Spielermodus { get; }
    }

    public delegate void StartGameEventHandler(object sender, StartGameEventArgs e);
}
