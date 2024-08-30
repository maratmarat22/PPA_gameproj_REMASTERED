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
        public int MissChance { get; set; }

        public Archer(int price, int health, int armor, int damage, int dodgeChance) : base(price, health, armor, damage, dodgeChance)
        {
            MissChance = 1;
        }

        public abstract void RangeAttack(Unit unit);
    }
}
