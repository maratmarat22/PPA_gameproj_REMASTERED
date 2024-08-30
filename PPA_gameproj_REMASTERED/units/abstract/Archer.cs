using PPA_gameproj_REMASTERED.units.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Archer : Unit, IRangeAttack
    {
        public Archer(int price, int health, int armor, int damage, int dodgeChance) : base(price, health, armor, damage, dodgeChance) { }

        public abstract void RangeAttack(Unit unit);
    }
}
