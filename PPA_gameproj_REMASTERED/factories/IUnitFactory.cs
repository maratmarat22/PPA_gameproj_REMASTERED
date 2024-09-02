using PPA_gameproj_REMASTERED.units.@abstract;
using PPA_gameproj_REMASTERED.units.concrete.@default;

namespace PPA_gameproj_REMASTERED.factories
{
    interface IUnitFactory
    {
        Dictionary<string, (int price, int health, int armor, int damage, int coverage, int missChance)> Parameters { get; set; }
        
        Infantryman CreateInfantryman();

        Archer CreateArcher();

        Swordsman CreateSwordsman();

        Knight CreateKnight();

        WagonFort CreateWagonFort()
        {
            var parameters = Parameters["WagonFort"];
            return new WagonFort(parameters.health, parameters.armor);
        }

        Healer CreateHealer();

        Magician CreateMagician();
    }
}
