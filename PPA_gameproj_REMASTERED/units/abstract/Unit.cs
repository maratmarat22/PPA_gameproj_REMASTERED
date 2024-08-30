namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Unit
    {
        public int Price { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }
        public int DodgeChance { get; set; }

        public Unit(int price, int health, int armor, int damage, int dodgeChance)
        {
            Price = price;
            Health = health;
            Armor = armor;
            Damage = damage;
            DodgeChance = dodgeChance;
        }

        public override string ToString() => $"{GetType().Name}({Health})";
    }
}
