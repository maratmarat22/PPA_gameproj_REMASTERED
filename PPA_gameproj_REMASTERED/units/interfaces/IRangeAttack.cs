using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.units.interfaces
{
    interface IRangeAttack
    {
        public int MissChance { get; set; }

        void RangeAttack(Unit unit);
    }
}
