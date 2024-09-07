using PPA_gameproj_REMASTERED.army;
using PPA_gameproj_REMASTERED.battlefields;
using PPA_gameproj_REMASTERED.commands;
using PPA_gameproj_REMASTERED.config;
using PPA_gameproj_REMASTERED.factories;
using PPA_gameproj_REMASTERED.units.interfaces;
using PPA_gameproj_REMASTERED.views;

namespace PPA_gameproj_REMASTERED
{
    class Gameplay
    {
        public IView View { get; set; }

        private Battlefield _battlefield;

        private int turn;

        public Gameplay(IView view)
        {
            View = view;
            turn = 0;
        }

        public void Init()
        {
            var unitsConfigManager = new UnitsConfigManager(@"..\..\..\config\units_config.csv");
            var unitParameters = unitsConfigManager.GetParameters();
            var prices = new List<int>();
            
            foreach (var unit in unitParameters)
            {
                prices.Add(unit.Value.price);
            }

            int budget = 100;

            View.DisplayArmyCreationMenu(prices, budget);

            var armyCreator = new ArmyCreator(new HumanUnitFactory(unitParameters));
            var humanArmy = armyCreator.CreateArmy("SASI");
            var humanArmy2 = armyCreator.CreateArmy("SASI");
            armyCreator.UnitFactory = new SkeletonUnitFactory(unitParameters);
            var skeletonArmy = armyCreator.CreateArmy("SASI");
            var skeletonArmy2 = armyCreator.CreateArmy("SASI");

            _battlefield = new Battlefield(new OneLineBattlefield(humanArmy2, skeletonArmy2));
        }

        public void Process()
        {
            var commandManager = new CommandManager();

            while (true)
            {
                var unitCoordinates = View.DisplayTurn(turn, _battlefield.ToString());
                var unit = _battlefield.GetAt(unitCoordinates.row).HumanArmy.Units.ElementAt(unitCoordinates.col);
                View.DisplayUnit(unit.ToString());
                var ability = View.DisplayAbilities(unit.GetAbilities());
                
                switch (ability)
                {
                    case 'S':
                        var army = _battlefield.GetAt(unitCoordinates.row).HumanArmy;
                        var targetOffset = View.DisplaySwapTargetSelection();
                        commandManager.RegisterCommand(new SwapCommand(army, unitCoordinates.col, unitCoordinates.col + targetOffset));
                        break;

                    case 'A':
                        break;

                    case 'H':
                        //commandManager.RegisterCommand(new HealCommand((IHeal)unit, targets));
                        break;
                }

                bool needCleaning = commandManager.ExecuteCommand();
                if (needCleaning)
                {
                    _battlefield.Clean();
                }

                ++turn;
            }
        }
    }
}
