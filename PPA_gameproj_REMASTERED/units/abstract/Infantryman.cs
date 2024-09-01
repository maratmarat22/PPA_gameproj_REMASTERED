using PPA_gameproj_REMASTERED.enums;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Infantryman : Unit
    {
        public Infantryman(int price, int health, int armor, int damage, int parryChance) : base(price, health, armor, damage, parryChance)
        {
            UnitAbilities = Abilities.Swap | Abilities.MeleeAttack;
        }
    }
}
