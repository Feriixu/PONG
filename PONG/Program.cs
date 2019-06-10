using System;
using System.Windows.Forms;

namespace PONG
{
    internal static class Program
    {
        private static IMainMenu mainMenu;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Erzeuge neues Main Menu
            mainMenu = new MainMenu();
            // Events Abonnieren
            mainMenu.StartEinzelspieler += StartGame;
            mainMenu.StartMehrspieler += StartGame;
            // MainMenu anzeigen
            //mainMenu.ShowMenu();
            Application.Run((Form)mainMenu);
        }


        private static void StartGame(object sender, StartGameEventArgs e)
        {
            // Einzelspieler ist noch nicht implementiert
            if (e.Spielermodus == Spielermodus.Einzelspieler)
                throw new NotImplementedException();

            // Neues PongGame erzeugen
            IPongGame pongGame = new PongGame(e.Spielermodus, e.Punktemodus);
            // Spiel starten
            pongGame.StartGame();
        }
    }
}
