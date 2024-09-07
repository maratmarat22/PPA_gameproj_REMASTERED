using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.units.interfaces
{
    // Не наследоваться от этого интерфейса!
    interface IAttack
    {
        int Damage { get; set; }

        bool Attack(params Unit[] units);
    }
}
