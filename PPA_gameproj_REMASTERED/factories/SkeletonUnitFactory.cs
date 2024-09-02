using PPA_gameproj_REMASTERED.units.@abstract;
using PPA_gameproj_REMASTERED.units.concrete.skeleton;

namespace PPA_gameproj_REMASTERED.factories
{
    class SkeletonUnitFactory : IUnitFactory
    {
        public Dictionary<string, (int price, int health, int armor, int damage, int coverage, int missChance)> Parameters { get; set; }

        public SkeletonUnitFactory(Dictionary<string, (int, int, int, int, int, int)> parameters)
        {
            Parameters = parameters;
        }

        public Infantryman CreateInfantryman()
        {
            var parameters = Parameters["Infantryman"];
            return new SkeletonInfantryman(parameters.health, parameters.armor, parameters.damage);
        }

        public Archer CreateArcher()
        {
            var parameters = Parameters["Archer"];
            return new SkeletonArcher(parameters.health, parameters.armor, parameters.damage, parameters.coverage, parameters.missChance);
        }

        public Swordsman CreateSwordsman()
        {
            var parameters = Parameters["Swordsman"];
            return new SkeletonSwordsman(parameters.health, parameters.armor, parameters.damage);
        }

        public Knight CreateKnight()
        {
            var parameters = Parameters["Knight"];
            return new SkeletonKnight(parameters.health, parameters.armor, parameters.damage);
        }

        public Healer CreateHealer()
        {
            var parameters = Parameters["Healer"];
            return new SkeletonHealer(parameters.health, parameters.armor);
        }

        public Magician CreateMagician()
        {
            var parameters = Parameters["Magician"];
            return new SkeletonMagician(parameters.health, parameters.armor, parameters.damage, parameters.coverage, parameters.missChance);
        }
    }
}
