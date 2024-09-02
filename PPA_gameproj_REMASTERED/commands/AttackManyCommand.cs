using PPA_gameproj_REMASTERED.units.@abstract;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.commands
{
    class AttackManyCommand : ICommand
    {
        private readonly IAttackMany _attacker;
        private readonly List<Unit> _targets;

        public AttackManyCommand(IAttackMany attacker, List<Unit> targets)
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
