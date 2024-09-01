using PPA_gameproj_REMASTERED.army;
using System.Text;

namespace PPA_gameproj_REMASTERED.battlefields
{
    class OneLineBattlefield : IBattlefield
    {
        public Army HumanArmy { get; set; }
        public Army SkeletonArmy { get; set; }

        public OneLineBattlefield(Army humanArmy, Army skeletonArmy)
        {
            HumanArmy = humanArmy;
            SkeletonArmy = skeletonArmy;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            foreach (var unit in HumanArmy.Units)
            {
                stringBuilder.Append(unit.ToString());
                stringBuilder.Append(' ');
            }

            stringBuilder.Append("||| ");

            foreach (var unit in SkeletonArmy.Units.AsEnumerable().Reverse())
            {
                stringBuilder.Append(unit.ToString());
                stringBuilder.Append(' ');
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
