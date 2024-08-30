using PPA_gameproj_REMASTERED.units.@abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA_gameproj_REMASTERED.factories
{
    interface IUnitFactory
    {
        Swordsman CreateSwordsman();

        Infantryman CreateInfantryman();

        Archer CreateArcher();
    }
}
