namespace PPA_gameproj_REMASTERED.battlefields
{
    class Battlefield : IBattlefield
    {
        public IBattlefield CurrentBattlefield { get; set; }

        public Battlefield(IBattlefield currentBattlefield)
        {
            CurrentBattlefield = currentBattlefield;
        }

        public OneLineBattlefield FindBattlefield(int index)
        {
            if (CurrentBattlefield is ManyLineBattlefield manyLineBattlefield)
            {
                return manyLineBattlefield.Battlefields[index];
            }

            return (OneLineBattlefield)CurrentBattlefield;
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
