namespace PPA_gameproj_REMASTERED.enums
{
    [Flags]
    public enum UnitAbilities
    {
        Swap = 1,
        MeleeAttack = 2,
        RangeAttack = 4,
        Defend = 8,
        RowAttack = 16,
        Heal = 32,
        ColAttack = 64
    }
}
