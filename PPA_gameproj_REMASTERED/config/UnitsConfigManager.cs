namespace PPA_gameproj_REMASTERED.config
{
    class UnitsConfigManager
    {
        public string ConfigFilePath { get; set; }
        
        public UnitsConfigManager(string configFilePath)
        {
            ConfigFilePath = configFilePath;
        }

        public Dictionary<string, (int price, int health, int armor, int damage, int coverage, int missChance)> GetParameters()
        {
            var parameters = new Dictionary<string, (int, int, int, int, int, int)>();

            using (var reader = new StreamReader(ConfigFilePath))
            {
                reader.ReadLine();
                
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');

                    var key = parts[0];
                    var stringValues = parts[1..];
                    var intValues = new int[stringValues.Length];

                    for (int i = 0; i < stringValues.Length; ++i)
                    {
                        intValues[i] = int.Parse(stringValues[i]);
                    }

                    var value = (intValues[0], intValues[1], intValues[2], intValues[3], intValues[4], intValues[5]);

                    parameters.Add(key, value);
                }
            }

            return parameters;
        }
    }
}
