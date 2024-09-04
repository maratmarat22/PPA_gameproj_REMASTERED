namespace PPA_gameproj_REMASTERED.views
{
    interface IView
    {
        byte DisplayMainMenu();

        string DisplayArmyCreationMenu(int budget);

        (byte row, byte col) DisplayTurn(int turn, string battlefieldString);

        byte DisplayAbilities(string[] abilities);
    }
}
