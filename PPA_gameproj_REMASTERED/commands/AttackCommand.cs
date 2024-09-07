using PPA_gameproj_REMASTERED.units.@abstract;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.commands
{
    class AttackCommand : ICommand
    {
        private readonly IAttack _attacker;
        private readonly Unit[] _targets;

        public AttackCommand(IAttack attacker, Unit[] targets)
        {
            _attacker = attacker;
            _targets = targets;
        }

        public bool Execute()
        {
            return _attacker.Attack(_targets);
        }
    }
}
