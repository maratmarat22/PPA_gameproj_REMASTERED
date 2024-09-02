using PPA_gameproj_REMASTERED.enums;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Infantryman : Unit, IAttackOne
    {
        public int Damage { get; set; }
        
        public Infantryman(int health, int armor, int damage) : base(health, armor)
        {
            Abilities = UnitAbilities.Swap | UnitAbilities.MeleeAttack;
            Damage = damage;
        }

        public void Attack(Unit unit)
        {
        
        }
    }
}
