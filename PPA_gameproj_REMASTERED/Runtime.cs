using PPA_gameproj_REMASTERED.views;

namespace PPA_gameproj_REMASTERED
{
    class Runtime
    {
        public static void Run()
        {
            IView view = new ConsoleView();

            char option = view.DisplayMainMenu();

            switch (option)
            {
                case '1':
                    var gameplay = new Gameplay(view);
                    gameplay.Init();
                    gameplay.Process();
                    break;

                case '2': // Load save
                    break;

                case '3': // Settings
                    break;

                case '4':
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
