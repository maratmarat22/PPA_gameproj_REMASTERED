using PPA_gameproj_REMASTERED.enums;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Infantryman : Unit, IAttackOne
    {
        public int Damage { get; set; }
        
        public Infantryman(int health, int armor, int damage) : base(health, armor)
        {
            Abilities = UnitAbilities.Swap | UnitAbilities.AttackOne;
            Damage = damage;
        }

        public bool Attack(Unit unit)
        {
            bool needCleaning = false;
            
            if (unit.Armor > 0)
            {
                --unit.Armor;
            }
            else
            {
                if (unit.Health - Damage > 0)
                {
                    unit.Health -= Damage;
                }
                else
                {
                    unit.Health = 0;
                    needCleaning = true;
                }
            }

            return needCleaning;
        }
    }
}
