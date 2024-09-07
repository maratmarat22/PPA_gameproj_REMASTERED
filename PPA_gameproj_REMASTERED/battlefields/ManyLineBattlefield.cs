using System.Text;

namespace PPA_gameproj_REMASTERED.battlefields
{
    class ManyLineBattlefield : IBattlefield
    {
        public OneLineBattlefield[] Battlefields { get; set; }

        public ManyLineBattlefield(params OneLineBattlefield[] battlefields)
        {
            Battlefields = battlefields;
        }

        public OneLineBattlefield GetAt(int index)
        {
            return Battlefields[index];
        }

        // Если в методе поля боя 1x1 еще не так критично пробежаться по всему списку,
        // то здесь стоит изменить реализацию на более оптимизированную
        public void Clean()
        {
            foreach (var battlefield in Battlefields)
            {
                battlefield.Clean();
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            foreach (var battlefield in Battlefields)
            {
                stringBuilder.AppendLine(battlefield.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
