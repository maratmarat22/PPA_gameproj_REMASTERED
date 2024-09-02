using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.units.interfaces
{
    interface IAttackMany : IAttack
    {
        bool Attack(List<Unit> units);
    }
}
