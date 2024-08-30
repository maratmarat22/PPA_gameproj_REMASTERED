using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA_gameproj_REMASTERED.battlefields
{
    class Battlefield
    {
        public IBattlefield CurrentBattlefield { get; set; }

        public Battlefield(IBattlefield currentBattlefield)
        {
            CurrentBattlefield = currentBattlefield;
        }
    }
}
