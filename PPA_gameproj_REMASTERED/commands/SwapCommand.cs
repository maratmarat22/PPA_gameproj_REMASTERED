using PPA_gameproj_REMASTERED.army;

namespace PPA_gameproj_REMASTERED.commands
{
    class SwapCommand : ICommand
    {
        private readonly Army _army;
        private readonly int _index1;
        private readonly int _index2;

        public SwapCommand(Army army, int index1, int index2)
        {
            _army = army;
            _index1 = index1;
            _index2 = index2;
        }

        public bool Execute()
        {
            return _army.SwapUnits(_index1, _index2);
        }
    }
}
