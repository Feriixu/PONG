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
            Application.Run(new MainMenu());
        }
    }
}
