using PPA_gameproj_REMASTERED.units.interfaces;
using PPA_gameproj_REMASTERED.enums;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Archer : Unit, IRange, IAttackOne
    {
        public int Damage { get; set; }
        public int Coverage { get; set; }
        public int MissChance { get; set; }

        public Archer(int health, int armor, int damage, int coverage, int missChance) : base(health, armor)
        {
            Abilities = UnitAbilities.Swap | UnitAbilities.RangeAttack;
            Damage = damage;
            Coverage = coverage;
            MissChance = missChance;
        }

        public void Attack(Unit unit)
        {
            
        }
    }
}
