using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.factories
{
    interface IUnitFactory
    {
        Swordsman CreateSwordsman();

        Infantryman CreateInfantryman();

        Archer CreateArcher();
    }
}
