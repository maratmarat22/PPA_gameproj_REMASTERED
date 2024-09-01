namespace PPA_gameproj_REMASTERED.views
{
    interface IView
    {
        byte DisplayMainMenu();

        string DisplayArmyCreationMenu(int budget);

        void DisplayBattlefield(string battlefieldString);
    }
}
