using PPA_gameproj_REMASTERED.enums;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Knight : Unit, IAttackMany
    {
        public int Damage { get; set; }
        
        public Knight(int health, int armor, int damage) : base(health, armor)
        {
            Abilities = UnitAbilities.Swap | UnitAbilities.MeleeAttack | UnitAbilities.Defend | UnitAbilities.RowAttack;
            Damage = damage;
        }

        public bool Attack(List<Unit> units)
        {
            bool needCleaning = false;
            
            foreach (var unit in units)
            {
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
            }

            return needCleaning;
        }
    }
}
