using PPA_gameproj_REMASTERED.units.@abstract;
using PPA_gameproj_REMASTERED.units.concrete.skeleton;

namespace PPA_gameproj_REMASTERED.factories
{
    internal class SkeletonUnitFactory : IUnitFactory
    {
        public Swordsman CreateSwordsman()
        {
            // Значения тестовые, только для возможности скомпилировать код
            return new SkeletonSwordsman(10, 10, 10, 10, 10);
        }

        public Infantryman CreateInfantryman()
        {
            return new SkeletonInfantryman(10, 10, 10, 10, 10);
        }

        public Archer CreateArcher()
        {
            return new SkeletonArcher(10, 10, 10, 10, 10);
        }
    }
}
