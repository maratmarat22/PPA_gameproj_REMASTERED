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
    }
}
