using PPA_gameproj_REMASTERED.army;
using PPA_gameproj_REMASTERED.battlefields;
using PPA_gameproj_REMASTERED.commands;
using PPA_gameproj_REMASTERED.config;
using PPA_gameproj_REMASTERED.factories;
using PPA_gameproj_REMASTERED.units.@abstract;
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

            var armyCreator = new ArmyCreator(new HumanUnitFactory(unitParameters));
            var humanArmy = armyCreator.CreateArmy("SASI");
            var humanArmy2 = armyCreator.CreateArmy("SASI");
            armyCreator.UnitFactory = new SkeletonUnitFactory(unitParameters);
            var skeletonArmy = armyCreator.CreateArmy("SASI");
            var skeletonArmy2 = armyCreator.CreateArmy("SASI");

            _battlefield = new Battlefield(new ManyLineBattlefield(new OneLineBattlefield(humanArmy, skeletonArmy), new OneLineBattlefield(humanArmy2, skeletonArmy2)));
        }

        public void Process()
        {
            var UnitCoordinates = View.DisplayTurn(1, _battlefield.ToString());
            Unit unit = _battlefield.FindBattlefield(UnitCoordinates.row - 1).HumanArmy.Units.ElementAt(UnitCoordinates.col - 1);
            View.DisplayAbilities(unit.GetAbilities());
        }
    }
}
