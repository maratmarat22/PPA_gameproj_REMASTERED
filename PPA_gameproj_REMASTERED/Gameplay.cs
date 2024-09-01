using PPA_gameproj_REMASTERED.army;
using PPA_gameproj_REMASTERED.battlefields;
using PPA_gameproj_REMASTERED.factories;
using PPA_gameproj_REMASTERED.units.concrete.human;
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

        // Впоследствии передавать информацию об игре в виде кортежа
        public void Init(/*Tuple<int, int, int> gameInfo*/)
        {
            int budget = 100;
            string armyString = View.DisplayArmyCreationMenu(budget);
            var armyCreator = new ArmyCreator(new HumanUnitFactory());
            var humanArmy = armyCreator.CreateArmy(armyString);
            armyCreator.UnitFactory = new SkeletonUnitFactory();
            var skeletonArmy = armyCreator.CreateArmy("SASISASI");

            _battlefield = new Battlefield(new OneLineBattlefield(humanArmy, skeletonArmy));
        }

        public void Process()
        {
            View.DisplayBattlefield(_battlefield.ToString());
            var arch = new HumanArcher(1, 1, 1, 1, 1);
            Console.WriteLine(arch.UnitAbilities);
        }
    }
}
