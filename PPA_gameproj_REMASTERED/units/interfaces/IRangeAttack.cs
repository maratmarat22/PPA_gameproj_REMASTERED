using PPA_gameproj_REMASTERED.units.@abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA_gameproj_REMASTERED.units.interfaces
{
    interface IRangeAttack
    {
        public int MissChance { get; set; }

        void RangeAttack(Unit unit);
    }
}
