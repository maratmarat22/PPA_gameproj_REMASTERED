using PPA_gameproj_REMASTERED.units.@abstract;
using PPA_gameproj_REMASTERED.units.concrete.human;

namespace PPA_gameproj_REMASTERED.factories
{
    class HumanUnitFactory : IUnitFactory
    {
        public Swordsman CreateSwordsman()
        {
            // Значения тестовые, только для возможности скомпилировать код
            return new HumanSwordsman(10, 10, 10, 10, 10);
        }

        public Infantryman CreateInfantryman()
        {
            return new HumanInfantryman(10, 10, 10, 10, 10);
        }

        public Archer CreateArcher()
        {
            return new HumanArcher(10, 10, 10, 10, 10);
        }
    }
}
