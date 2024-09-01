using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.units.concrete.human
{
    class HumanSwordsman : Swordsman
    {
        public HumanSwordsman(int price, int health, int armor, int damage, int dodgeChance) : base(price, health, armor, damage, dodgeChance) { }
    }
}
