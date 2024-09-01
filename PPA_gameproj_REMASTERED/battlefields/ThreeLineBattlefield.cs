using PPA_gameproj_REMASTERED.army;

namespace PPA_gameproj_REMASTERED.battlefields
{
    class ThreeLineBattlefield : IBattlefield
    {
        private Army _humanArmy1, _humanArmy2, _humanArmy3;
        private Army _skeletonArmy1, _skeletonArmy2, _skeletonArmy3;

        public ThreeLineBattlefield(Army hArmy1, Army hArmy2, Army hArmy3, Army sArmy1, Army sArmy2, Army sArmy3)
        {
            _humanArmy1 = hArmy1;
            _humanArmy2 = hArmy2;
            _humanArmy3 = hArmy3;
            _skeletonArmy1 = sArmy1;
            _skeletonArmy2 = sArmy2;
            _skeletonArmy3 = sArmy3;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
