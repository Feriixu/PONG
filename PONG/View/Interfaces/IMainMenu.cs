namespace PONG
{
    public interface IMainMenu
    {
        event StartGameEventHandler StartEinzelspieler;
        event StartGameEventHandler StartMehrspieler;
        void ShowMenu();
    }
}