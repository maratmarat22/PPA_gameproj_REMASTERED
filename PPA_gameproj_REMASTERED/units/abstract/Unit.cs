using PPA_gameproj_REMASTERED.enums;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Unit
    {
        public int Health { get; set; }
        public int Armor { get; set; }        
        public UnitAbilities Abilities { get; set; }

        public Unit(int health, int armor)
        {
            Health = health;
            Armor = armor;
        }

        public string[] GetAbilities()
        {
            return Abilities.ToString().Split(", ");
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

            return unitShortName + $"({Health}/{Armor})";
        }
    }
}
