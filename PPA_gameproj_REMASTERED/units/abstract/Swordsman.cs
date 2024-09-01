﻿using PPA_gameproj_REMASTERED.enums;

namespace PPA_gameproj_REMASTERED.units.@abstract
{
    abstract class Swordsman : Unit
    {
        public Swordsman(int price, int health, int armor, int damage, int dodgeChance) : base(price, health, armor, damage, dodgeChance)
        {
            UnitAbilities = Abilities.Swap | Abilities.MeleeAttack | Abilities.Defend;
        }
    }
}
