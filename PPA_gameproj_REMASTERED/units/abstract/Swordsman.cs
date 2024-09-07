using PPA_gameproj_REMASTERED.enums;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Swordsman : Unit, IAttack
    {
        public int Damage { get; set; }
        
        public Swordsman(int health, int armor, int damage) : base(health, armor)
        {
            Abilities = UnitAbilities.Swap | UnitAbilities.Attack;
            Damage = damage;
        }

        public bool Attack(params Unit[] targets)
        {
            bool needCleaning = false;

            Unit target = targets[0];

            if (target.Armor > 0)
            {
                --target.Armor;
            }
            else
            {
                if (target.Health - Damage > 0)
                {
                    target.Health -= Damage;
                }
                else
                {
                    target.Health = 0;
                    needCleaning = true;
                }
            }

            return needCleaning;
        }
    }
}
