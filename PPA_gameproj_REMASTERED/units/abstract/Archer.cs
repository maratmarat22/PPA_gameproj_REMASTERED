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
            Abilities = UnitAbilities.Swap | UnitAbilities.AttackOne;
            Damage = damage;
            Coverage = coverage;
            MissChance = missChance;
        }

        public bool Attack(Unit unit)
        {
            bool needCleaning = false;
            
            // Добавить шанс промаха лучнику и магу
            if (unit.Armor == 0)
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
