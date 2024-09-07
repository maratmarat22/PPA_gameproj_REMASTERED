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
        
        public char DisplayMainMenu()
        {
            Console.Clear();
            _writer.WriteLine("PPA_gameproj_REMASTERED\n");
            _writer.WriteLine("1. Start new game");
            _writer.WriteLine("2. Load game");
            _writer.WriteLine("3. Settings");
            _writer.WriteLine("4. Exit");

            var validOptions = "1234";

            return GetCharOption(validOptions);
        }

        private char GetCharOption(string validOptions)
        {
            string? option = _reader.ReadLine();

            while (string.IsNullOrWhiteSpace(option) || option.Length != 1 || !validOptions.Contains(option))
            {
                _writer.WriteLine("Invalid option");
                option = _reader.ReadLine();
            }

            return char.Parse(option);
        }
        
        public string DisplayArmyCreationMenu(List<int> prices, int budget)
        {
            Console.Clear();
            _writer.WriteLine("Army Creation Menu\n");
            _writer.WriteLine($"1. Infantryman - {prices[0]}");
            _writer.WriteLine($"2. Archer - {prices[1]}");
            _writer.WriteLine($"3. Swordsman - {prices[2]}");
            _writer.WriteLine($"4. Knight - {prices[3]}");
            _writer.WriteLine($"5. Wagon fort - {prices[4]}");
            _writer.WriteLine($"6. Healer - {prices[5]}");
            _writer.WriteLine($"7. Magician - {prices[6]}");
            _writer.WriteLine("0. Confirm & continue\n");

            string validOptions = "01234567";

            var stringBuilder = new StringBuilder();

            while (budget > 0)
            {
                _writer.WriteLine($"Gold: {budget}");

                char option = GetCharOption(validOptions);

                if (option == '0')
                {
                    if (stringBuilder.Length > 0)
                    {
                        break;
                    }
                    else
                    {
                        _writer.WriteLine("You should hire at least 1 unit!");
                    }
                }
                else
                {
                    switch (option)
                    {
                        case '1':
                            stringBuilder.Append('I');
                            budget -= prices[0];
                            break;
                        case '2':
                            stringBuilder.Append('A');
                            budget -= prices[1];
                            break;
                        case '3':
                            stringBuilder.Append('S');
                            budget -= prices[3];
                            break;
                        case '4':
                            stringBuilder.Append('K');
                            budget -= prices[4];
                            break;
                        case '5':
                            stringBuilder.Append('W');
                            budget -= prices[5];
                            break;
                        case '6':
                            stringBuilder.Append('H');
                            budget -= prices[6];
                            break;
                        case '7':
                            stringBuilder.Append('M');
                            budget -= prices[7];
                            break;
                    }
                }
            }

            return stringBuilder.ToString();
        }

        private void DisplayBattlefield(string battlefieldString)
        {
            _writer.WriteLine(battlefieldString);
        }

        private (bool isValid, int row, int col) ValidateCoordinates(string? option)
        {
            bool correctFormat = !string.IsNullOrWhiteSpace(option) &&
                option.Contains('/') &&
                option.Split('/').Length == 2;

            if (!correctFormat)
            {
                return (false, 0, 0);
            }

            var coordinates = option!.Split('/');

            bool convertible = int.TryParse(coordinates[0], out int row) & int.TryParse(coordinates[1], out int col);
            bool notZero = row > 0 && col > 0;

            return (convertible && notZero, row, col);
        }

        public (int row, int col) DisplayTurn(int turn, string battlefieldString)
        {
            Console.Clear();
            _writer.WriteLine($"Turn: {turn}");
            DisplayBattlefield(battlefieldString);
            _writer.WriteLine("Enter unit's coordinates, format: row/col");

            var option = _reader.ReadLine();
            var validationResults = ValidateCoordinates(option);

            while (!validationResults.isValid)
            {
                _writer.WriteLine("Invalid option");
                option = _reader.ReadLine();
                validationResults = ValidateCoordinates(option);
            }

            return (validationResults.row - 1, validationResults.col - 1);
        }

        public char DisplayAbilities(string[] abilities)
        {
            int index = 1;
            foreach (var ability in abilities)
            {
                _writer.WriteLine($"{index}: {ability}");
                ++index;
            }

            var option = _reader.ReadLine();
            int intOption;

            while (!int.TryParse(option, out intOption) || intOption <= 0 || intOption >= index)
            {
                _writer.WriteLine("Invalid option");
                option = _reader.ReadLine();
            }

            --intOption;

            return abilities[intOption][0];
        }

        public int DisplaySwapTargetSelection()
        {
            _writer.WriteLine("With whom would you want this unit to swap: left or right unit? l/r");

            char option = GetCharOption("lr");

            if (option == 'l')
            {
                return -1;
            }

            return 1;
        }

        public void DisplayUnit(string unitString)
        {
            _writer.WriteLine(unitString);
        }

        public void Dispose()
        {
            _writer.Dispose();
            _reader.Dispose();
        }
    }
}
