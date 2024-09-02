using PPA_gameproj_REMASTERED.units.@abstract;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.commands
{
    class AttackOneCommand : ICommand
    {
        private readonly IAttackOne _attacker;
        private readonly Unit _target;

        public AttackOneCommand(IAttackOne attacker, Unit target)
        {
            _attacker = attacker;
            _target = target;
        }

        public bool Execute()
        {
            return _attacker.Attack(_target);
        }
    }
}
