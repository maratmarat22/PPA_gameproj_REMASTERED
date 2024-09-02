using PPA_gameproj_REMASTERED.units.@abstract;

namespace PPA_gameproj_REMASTERED.army
{
    class Army
    {
        // Возможно, потребуется поменять на LinkedList
        public List<Unit> Units { get; set; }

        public Army(List<Unit> units)
        {
            Units = units;
        }

        public bool SwapUnits(int index1, int index2)
        {
            bool needCleaning = false;
            
            var buff = Units[index2];
            Units[index2] = Units[index1];
            Units[index1] = buff;

            return needCleaning;
        }
    }
}
