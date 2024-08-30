using PPA_gameproj_REMASTERED.units.@abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA_gameproj_REMASTERED.units.concrete.human
{
    class HumanInfantryman : Infantryman
    {
        public HumanInfantryman(int price, int health, int armor, int damage, int dodgeChance) : base(price, health, armor, damage, dodgeChance) { }
    }
}
