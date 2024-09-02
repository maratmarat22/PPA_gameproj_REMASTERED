using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.units.concrete.human
{
    class HumanArcher : Archer
    {
        public HumanArcher(int health, int armor, int damage, int coverage, int missChance) : base(health, armor, damage, coverage, missChance) { }
    }
}
