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
            Abilities = UnitAbilities.Swap | UnitAbilities.AttackMany;
            Damage = damage;
            Coverage = coverage;
            MissChance = missChance;
        }

        public bool Attack(List<Unit> units)
        {
            bool needCleaning = false;
            
            // Добавить шанс промаха лучнику и магу
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
