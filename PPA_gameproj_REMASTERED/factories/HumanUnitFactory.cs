using PPA_gameproj_REMASTERED.units.@abstract;
using PPA_gameproj_REMASTERED.units.concrete.human;

namespace PPA_gameproj_REMASTERED.factories
{
    class HumanUnitFactory : IUnitFactory
    {
        public Dictionary<string, (int price, int health, int armor, int damage, int coverage, int missChance)> Parameters { get; set; }

        public HumanUnitFactory(Dictionary<string, (int, int, int, int, int, int)> parameters)
        {
            Parameters = parameters;
        }
        
        public Infantryman CreateInfantryman()
        {
            var parameters = Parameters["Infantryman"];
            return new HumanInfantryman(parameters.health, parameters.armor, parameters.damage);
        }

        public Archer CreateArcher()
        {
            var parameters = Parameters["Archer"];
            return new HumanArcher(parameters.health, parameters.armor, parameters.damage, parameters.coverage, parameters.missChance);
        }

        public Swordsman CreateSwordsman()
        {
            var parameters = Parameters["Swordsman"];
            return new HumanSwordsman(parameters.health, parameters.armor, parameters.damage);
        }

        public Knight CreateKnight()
        {
            var parameters = Parameters["Knight"];
            return new HumanKnight(parameters.health, parameters.armor, parameters.damage);
        }

        public Healer CreateHealer()
        {
            var parameters = Parameters["Healer"];
            return new HumanHealer(parameters.health, parameters.armor);
        }

        public Magician CreateMagician()
        {
            var parameters = Parameters["Magician"];
            return new HumanMagician(parameters.health, parameters.armor, parameters.damage, parameters.coverage, parameters.missChance);
        }
    }
}
