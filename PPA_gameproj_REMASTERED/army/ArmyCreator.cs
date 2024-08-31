using PPA_gameproj_REMASTERED.factories;
using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.army
{
    class ArmyCreator
    {
        public IUnitFactory UnitFactory { get; set; }

        public ArmyCreator(IUnitFactory unitFactory)
        {
            UnitFactory = unitFactory;
        }

        /// <summary>
        /// Возвращает готовую армию из юнитов. Должен создавать армию как по желанию пользователя, так и по данным из БД.
        /// Армию можно передавать в качестве строки в формате "SSIAIS", где каждая буква означает имя юнита.
        /// </summary>
        public Army CreateArmy(string armyString)
        {
            var units = new List<Unit>();

            foreach (char ch in armyString)
            {
                switch (ch)
                {
                    case 'S':
                        units.Add(UnitFactory.CreateSwordsman());
                        break;

                    case 'I':
                        units.Add(UnitFactory.CreateInfantryman());
                        break;

                    case 'A':
                        units.Add(UnitFactory.CreateArcher());
                        break;

                    default:
                        // Можно добавить обработку исключения, хотя все неподходящие опции не попадут в этот метод
                        break;
                }
            }

            return new Army(units);
        }
    }
}
