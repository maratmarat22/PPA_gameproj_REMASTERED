using PPA_gameproj_REMASTERED.units.interfaces;
using PPA_gameproj_REMASTERED.enums;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Archer : Unit, IRangeAttack
    {
        public int MissChance { get; set; }

        public Archer(int price, int health, int armor, int damage, int parryChance) : base(price, health, armor, damage, parryChance)
        {
            MissChance = 1;
            UnitAbilities = Abilities.Swap | Abilities.RangeAttack;
        }

        public abstract void RangeAttack(Unit unit);
    }
}
