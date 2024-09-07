namespace PPA_gameproj_REMASTERED.battlefields
{
    class Battlefield : IBattlefield
    {
        public IBattlefield CurrentBattlefield { get; set; }

        public Battlefield(IBattlefield currentBattlefield)
        {
            CurrentBattlefield = currentBattlefield;
        }

        public OneLineBattlefield GetAt(int index)
        {
            return CurrentBattlefield.GetAt(index);
        }

        public void Clean()
        {
            CurrentBattlefield.Clean();
        }

        public override string ToString()
        {
            return CurrentBattlefield.ToString();
        }
    }
}
