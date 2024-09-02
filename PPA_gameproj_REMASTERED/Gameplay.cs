using PPA_gameproj_REMASTERED.army;
using PPA_gameproj_REMASTERED.battlefields;
using PPA_gameproj_REMASTERED.config;
using PPA_gameproj_REMASTERED.factories;
using PPA_gameproj_REMASTERED.views;

namespace PPA_gameproj_REMASTERED
{
    class Gameplay
    {
        public IView View { get; set; }
        private Battlefield _battlefield;

        public Gameplay(IView view)
        {
            View = view;
        }

        public void Init()
        {
            var unitsConfigManager = new UnitsConfigManager(@"..\..\..\config\units_config.csv");
            var unitParameters = unitsConfigManager.GetParameters();

            int budget = 100;
            string armyString = View.DisplayArmyCreationMenu(budget);
            var armyCreator = new ArmyCreator(new HumanUnitFactory(unitParameters));
            var humanArmy = armyCreator.CreateArmy(armyString);
            armyCreator.UnitFactory = new SkeletonUnitFactory(unitParameters);
            var skeletonArmy = armyCreator.CreateArmy("SASISASI");

            _battlefield = new Battlefield(new OneLineBattlefield(humanArmy, skeletonArmy));
        }

        public void Process()
        {
            View.DisplayBattlefield(_battlefield.ToString());
        }
    }
}
