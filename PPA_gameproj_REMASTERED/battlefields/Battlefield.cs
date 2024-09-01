namespace PPA_gameproj_REMASTERED.battlefields
{
    class Battlefield : IBattlefield
    {
        public IBattlefield CurrentBattlefield { get; set; }

        public Battlefield(IBattlefield currentBattlefield)
        {
            CurrentBattlefield = currentBattlefield;
        }

        public override string ToString()
        {
            return CurrentBattlefield.ToString();
        }
    }
}
