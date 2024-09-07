namespace PPA_gameproj_REMASTERED
{
    sealed class RandomSingleton
    {
        private RandomSingleton() { }

        private static Random? _instance;

        public static Random GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Random();
            }
            return _instance;
        }
    }
}
