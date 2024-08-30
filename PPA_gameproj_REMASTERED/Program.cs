using PPA_gameproj_REMASTERED.army;
using PPA_gameproj_REMASTERED.factories;

namespace PPA_gameproj_REMASTERED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var humanFactory = new HumanUnitFactory();
            var armyCreator = new ArmyCreator(humanFactory);
            Army humanArmy = armyCreator.CreateArmy("SSIAS");
            armyCreator.UnitFactory = new SkeletonUnitFactory();
            Army skeletonArmy = armyCreator.CreateArmy("IIIII");
        }
    }
}