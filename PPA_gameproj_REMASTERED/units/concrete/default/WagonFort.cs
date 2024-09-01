using PPA_gameproj_REMASTERED.enums;
using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.units.concrete.@default
{
    class WagonFort : Unit
    {
        public WagonFort(int price, int health, int armor, int damage, int parryChance) : base(price, health, armor, damage, parryChance)
        {
            UnitAbilities = Abilities.None;
        }
    }
}
