using PPA_gameproj_REMASTERED.army;

namespace PPA_gameproj_REMASTERED.battlefields
{
    interface IBattlefield
    {
        OneLineBattlefield GetAt(int index);
        
        void Clean();

        string ToString();
    }
}
