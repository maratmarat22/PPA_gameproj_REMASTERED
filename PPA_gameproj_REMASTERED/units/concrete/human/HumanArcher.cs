using PPA_gameproj_REMASTERED.units.@abstract;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.units.concrete.human
{
    class HumanArcher : Archer
    {
        public HumanArcher(int price, int health, int armor, int damage, int dodgeChance) : base(price, health, armor, damage, dodgeChance) { }

        public override void RangeAttack(Unit unit)
        {
            
        }
    }
}
