using PPA_gameproj_REMASTERED.enums;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Unit
    {
        public int Price { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }
        public int ParryChance { get; set; }
        public Abilities UnitAbilities { get; set; }

        public Unit(int price, int health, int armor, int damage, int parryChance)
        {
            Price = price;
            Health = health;
            Armor = armor;
            Damage = damage;
            ParryChance = parryChance;
        }

        public IEnumerable<string> GetAbilities()
        {
            int index = 1;
            foreach (Abilities ability in Enum.GetValues(typeof(Abilities)))
            {
                if (ability == Abilities.None)
                {
                    yield break;
                }
                
                yield return $"{index}. {ability}";
                ++index;
            }
        }

        public override string ToString()
        {
            string unitFullName = GetType().Name;
            string unitShortName = string.Empty;

            foreach (char ch in unitFullName)
            {
                if (char.IsUpper(ch))
                    unitShortName += ch;
            }

            return unitShortName + $"({Health})";
        }
    }
}
