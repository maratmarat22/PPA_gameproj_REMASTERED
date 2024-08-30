using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.units.concrete.skeleton
{
    internal class SkeletonArcher : Archer
    {
        public SkeletonArcher(int price, int health, int armor, int damage, int dodgeChance) : base(price, health, armor, damage, dodgeChance) { }

        public override void RangeAttack(Unit unit)
        {

        }
    }
}
