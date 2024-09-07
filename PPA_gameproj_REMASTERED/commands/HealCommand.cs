using PPA_gameproj_REMASTERED.units.@abstract;
using PPA_gameproj_REMASTERED.units.interfaces;

namespace PPA_gameproj_REMASTERED.commands
{
    class HealCommand : ICommand
    {
        private readonly IHeal _healer;
        private readonly Unit[] _targets;

        public HealCommand(IHeal healer, Unit[] targets)
        {
            _healer = healer;
            _targets = targets;
        }

        public bool Execute()
        {
            return _healer.Heal(_targets);
        }
    }
}
