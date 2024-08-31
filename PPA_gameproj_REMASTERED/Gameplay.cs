using PPA_gameproj_REMASTERED.army;
using PPA_gameproj_REMASTERED.factories;
using PPA_gameproj_REMASTERED.views;

namespace PPA_gameproj_REMASTERED
{
    class Gameplay
    {
        public IView View { get; set; }

        public Gameplay(IView view)
        {
            View = view;
        }

        public void Init()
        {
            int budget = 100;
            string armyString = View.DisplayArmyCreationMenu(budget);
            var armyCreator = new ArmyCreator(new HumanUnitFactory());
            var humanArmy = armyCreator.CreateArmy(armyString);
            armyCreator.UnitFactory = new SkeletonUnitFactory();
            var skeletonArmy = armyCreator.CreateArmy("SASISASI");
        }

        public void Process()
        {
        
        }
    }
}
