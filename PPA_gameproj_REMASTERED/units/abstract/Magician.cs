using PPA_gameproj_REMASTERED.enums;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Magician : Unit, IRange, IAttackMany
    {
        public int Damage { get; set; }
        public int Coverage { get; set; }
        public int MissChance { get; set; }
        
        public Magician(int health, int armor, int damage, int coverage, int missChance) : base(health, armor)
        {
            Abilities = UnitAbilities.Swap | UnitAbilities.RowAttack | UnitAbilities.ColAttack;
            Damage = damage;
            Coverage = coverage;
            MissChance = missChance;
        }

        public void Attack(List<Unit> units)
        {
        
        }
    }
}
