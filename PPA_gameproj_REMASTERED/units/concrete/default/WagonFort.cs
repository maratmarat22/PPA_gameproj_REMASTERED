using PPA_gameproj_REMASTERED.enums;
using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.units.concrete.@default
{
    class WagonFort : Unit
    {
        public WagonFort(int health, int armor) : base(health, armor)
        {
            Abilities = UnitAbilities.Swap;
        }
    }
}
