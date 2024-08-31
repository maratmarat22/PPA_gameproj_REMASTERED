using System.Text;

namespace PPA_gameproj_REMASTERED.views
{
    class ConsoleView : IView
    {
        private readonly StreamWriter _writer;
        private readonly StreamReader _reader;

        public ConsoleView()
        {
            _writer = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
            _reader = new StreamReader(Console.OpenStandardInput());
        }
        
        public byte DisplayMainMenu()
        {
            _writer.WriteLine("PPA_gameproj_REMASTERED\n");
            _writer.WriteLine("1. Start new game");
            _writer.WriteLine("2. Exit");

            string validOptions = "12";

            string? option = _reader.ReadLine();

            while (string.IsNullOrWhiteSpace(option) || option.Length != 1 || !validOptions.Contains(option))
            {
                _writer.WriteLine("Invalid option");
                option = _reader.ReadLine();
            }

            return byte.Parse(option);
        }

        public string DisplayArmyCreationMenu(int budget)
        {
            _writer.WriteLine("Army Creation Menu\n");
            _writer.WriteLine("1. Swordsman");
            _writer.WriteLine("2. Infantryman");
            _writer.WriteLine("3. Archer");
            _writer.WriteLine("0. Confirm & continue\n");

            string validOptions = "1230";

            var stringBuilder = new StringBuilder();

            while (budget > 0)
            {
                _writer.WriteLine($"Gold: {budget}");

                string? option = _reader.ReadLine();

                if (option == "0")
                    break;

                while (string.IsNullOrWhiteSpace(option) || option.Length != 1 || !validOptions.Contains(option))
                {
                    _writer.WriteLine("Invalid option");
                    option = _reader.ReadLine();
                }

                switch (option)
                {
                    case "1":
                        stringBuilder.Append("S");
                        
                        // Цены на юнитов стоит перенести в отдельную структуру, которую передавать и в этот метод, и в фабричные методы
                        budget -= 10;
                        break;
                    
                    case "2":
                        stringBuilder.Append("I");
                        budget -= 10;
                        break;

                    case "3":
                        stringBuilder.Append("A");
                        budget -= 10;
                        break;
                }
            }

            return stringBuilder.ToString();
        }
    }
}
