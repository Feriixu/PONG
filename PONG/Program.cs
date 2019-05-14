using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONG
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
<<<<<<< HEAD
            Application.Run(new Spiel());
=======
            // Application.Run(new Game());
>>>>>>> f7e0131de4265cf1670d0c228f0738cd08a1e6a8
        }
    }
}
