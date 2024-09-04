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

        public bool Heal(List<Unit> units)
        {
            bool needCleaning = false;

            foreach (var unit in units)
            {
                if (unit.Health < 0 /*unit.MaxHealth*/)
                {
                    ++unit.Health;
                }
            }

            return needCleaning;
        }
    }
}
