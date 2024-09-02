using PPA_gameproj_REMASTERED.enums;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Swordsman : Unit, IAttackOne
    {
        public int Damage { get; set; }
        
        public Swordsman(int health, int armor, int damage) : base(health, armor)
        {
            Abilities = UnitAbilities.Swap | UnitAbilities.MeleeAttack | UnitAbilities.Defend;
            Damage = damage;
        }

        public void Attack(Unit unit)
        {
        
        }
    }
}
