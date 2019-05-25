using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONG
{
    static class Program
    {
        public static MainMenu MainMenu
        {
            get => MainMenu;
            set
            {
            }
        }

        public static Spielfeld Spielfeld
        {
            get => Spielfeld;
            set
            {
            }
        }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainMenu = new MainMenu();
            MainMenu.StartEinzelspieler += StartEinzelspieler;
            MainMenu.StartMehrspieler += StartMehrspieler;
            MainMenu.Show();
        }

        private static void StartMehrspieler(object sender, MainMenuEventArgs e)
        {
            MainMenu.Hide();
            Spielfeld = new Spielfeld(e.Spielmodus, false);
            Spielfeld.ShowDialog();
            MainMenu.Show();
        }

        private static void StartEinzelspieler(object sender, MainMenuEventArgs e)
        {
            MainMenu.Hide();
            Spielfeld = new Spielfeld(e.Spielmodus, true);
            Spielfeld.ShowDialog();
            MainMenu.Show();
        }
    }
}
