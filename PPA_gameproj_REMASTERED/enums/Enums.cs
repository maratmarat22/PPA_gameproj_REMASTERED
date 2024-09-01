namespace PPA_gameproj_REMASTERED.enums
{
    [Flags]
    public enum Abilities
    {
        None = 0,
        Swap = 1,
        MeleeAttack = 2,
        Defend = 4,
        RangeAttack = 8,
        Heal = 16,
        CastColSpell = 32,
        CastRowSpell = 64
    }
}
