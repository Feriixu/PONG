using System;

namespace PONG
{
    public interface IMainMenu
    {
        event EventHandler StartEinzelspieler;
        event EventHandler StartMehrspieler;
    }
}