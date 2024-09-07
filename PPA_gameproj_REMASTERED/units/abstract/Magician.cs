using PPA_gameproj_REMASTERED.enums;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Magician : Unit, IRange, IAttack
    {
        public int Damage { get; set; }

        public int Coverage { get; set; }

        public int MissChance { get; set; }
        
        public Magician(int health, int armor, int damage, int coverage, int missChance) : base(health, armor)
        {
            Abilities = UnitAbilities.Swap | UnitAbilities.Attack;
            Damage = damage;
            Coverage = coverage;
            MissChance = missChance;
        }

        public bool Attack(params Unit[] targets)
        {
            bool needCleaning = false;

            var random = RandomSingleton.GetInstance();

            if (random.Next(100) > MissChance)
            {
                foreach (var target in targets)
                {
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
                }
            }

            return needCleaning;
        }
    }
}
