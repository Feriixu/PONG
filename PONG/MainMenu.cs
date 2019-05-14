using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONG
{
    public partial class MainMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PictureBoxEinzelspieler_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxMehrspieler_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxMehrspieler_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.mehrDisabled;
        }

        private void PictureBoxMehrspieler_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.mehr;
        }

        private void PictureBoxEinzelspieler_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.einzel;
        }

        private void PictureBoxEinzelspieler_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.einzelDisabled;
        }
    }
}
