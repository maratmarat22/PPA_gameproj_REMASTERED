using System.Text;

namespace PPA_gameproj_REMASTERED.views
{
    class ConsoleView : IView, IDisposable
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
            Console.Clear();
            _writer.WriteLine("PPA_gameproj_REMASTERED\n");
            _writer.WriteLine("1. Start new game");
            _writer.WriteLine("2. Load game");
            _writer.WriteLine("3. Settings");
            _writer.WriteLine("4. Exit");

            string validOptions = "1234";

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
            Console.Clear();
            _writer.WriteLine("Army Creation Menu\n");
            _writer.WriteLine("1. Infantryman");
            _writer.WriteLine("2. Archer");
            _writer.WriteLine("3. Swordsman");
            _writer.WriteLine("4. Knight");
            _writer.WriteLine("5. Wagon fort");
            _writer.WriteLine("6. Healer");
            _writer.WriteLine("7. Magician");
            _writer.WriteLine("0. Confirm & continue\n");

            string validOptions = "12345670";

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
                        stringBuilder.Append("I");                        
                        // Цены на юнитов стоит перенести в отдельную структуру, которую передавать и в этот метод, и в фабричные методы
                        budget -= 10;
                        break;                    
                    case "2":
                        stringBuilder.Append("A");
                        budget -= 10;
                        break;
                    case "3":
                        stringBuilder.Append("S");
                        budget -= 10;
                        break;
                    case "4":
                        stringBuilder.Append("K");
                        budget -= 10;
                        break;
                    case "5":
                        stringBuilder.Append("W");
                        budget -= 10;
                        break;
                    case "6":
                        stringBuilder.Append("H");
                        budget -= 10;
                        break;
                    case "7":
                        stringBuilder.Append("M");
                        budget -= 10;
                        break;
                }
            }

            return stringBuilder.ToString();
        }

        private void DisplayBattlefield(string battlefieldString)
        {
            _writer.WriteLine(battlefieldString);
        }

        private (bool isValid, byte row, byte col) ValidateCoordinates(string option)
        {
            bool correctFormat = !string.IsNullOrWhiteSpace(option) &&
                option.Contains('/') &&
                option.Split('/').Length == 2;

            if (!correctFormat)
            {
                return (false, 0, 0);
            }

            var coordinates = option.Split('/');

            bool convertible = byte.TryParse(coordinates[0], out byte row) & byte.TryParse(coordinates[1], out byte col);

            return (convertible, row, col);
        }

        public (byte row, byte col) DisplayTurn(int turn, string battlefieldString)
        {
            Console.Clear();
            _writer.WriteLine($"Turn: {turn}");
            DisplayBattlefield(battlefieldString);
            _writer.WriteLine("Enter unit's coordinates, format: row/col");

            var option = _reader.ReadLine();
            var validationResults = ValidateCoordinates(option!);

            while (!validationResults.isValid)
            {
                _writer.WriteLine("Invalid option");
                option = _reader.ReadLine();
                validationResults = ValidateCoordinates(option!);
            }

            return (validationResults.row, validationResults.col);
        }

        public byte DisplayAbilities(string[] abilities)
        {
            byte index = 1;
            foreach (var ability in abilities)
            {
                _writer.WriteLine($"{index}: {ability}");
                ++index;
            }

            // Добавить нормальную обработку
            var option = _reader.ReadLine();
            byte byteOption = byte.Parse(option);

            while (string.IsNullOrWhiteSpace(option) || byteOption > index)
            {
                _writer.WriteLine("Invalid option");
                option = _reader.ReadLine();
                byteOption = byte.Parse(option);
            }

            return byteOption;
        }

        public void Dispose()
        {
            _writer.Dispose();
            _reader.Dispose();
        }
    }
}
