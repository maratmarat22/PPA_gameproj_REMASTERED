using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.units.interfaces
{
    interface IAttackMany : IAttack
    {
        void Attack(List<Unit> units);
    }
}
