using PPA_gameproj_REMASTERED.enums;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Healer : Unit, IHeal
    {
        public Healer(int health, int armor) : base(health, armor)
        {
            Abilities = UnitAbilities.Swap | UnitAbilities.Heal;
        }

        public bool Heal(Unit[] targets)
        {
            bool needCleaning = false;

            foreach (var target in targets)
            {
                if (target.Health < target.maxHealth)
                {
                    ++target.Health;
                }
            }

            return needCleaning;
        }
    }
}
