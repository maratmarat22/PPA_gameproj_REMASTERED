namespace PPA_gameproj_REMASTERED.config
{
    class UnitsConfigManager
    {
        public string ConfigFilePath { get; set; }
        
        public UnitsConfigManager(string configFilePath)
        {
            ConfigFilePath = configFilePath;
        }

        public Dictionary<string, (int, int, int, int, int, int)> GetParameters()
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
                    var IntValues = new int[stringValues.Length];

                    for (int i = 0; i < stringValues.Length; ++i)
                    {
                        IntValues[i] = int.Parse(stringValues[i]);
                    }

                    var value = (IntValues[0], IntValues[1], IntValues[2], IntValues[3], IntValues[4], IntValues[5]);

                    parameters.Add(key, value);
                }
            }

            return parameters;
        }
    }
}
