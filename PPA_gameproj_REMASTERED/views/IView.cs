namespace PPA_gameproj_REMASTERED.views
{
    interface IView
    {
        char DisplayMainMenu();

        string DisplayArmyCreationMenu(List<int> prices, int budget);

        (int row, int col) DisplayTurn(int turn, string battlefieldString);

        char DisplayAbilities(string[] abilities);

        int DisplaySwapTargetSelection();

        void DisplayUnit(string unitString);
    }
}
