namespace PPA_gameproj_REMASTERED.commands
{
    class CommandManager
    {
        public readonly List<ICommand> commands;

        CommandManager()
        {
            commands = new List<ICommand>();
        }

        public void RegisterCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void ExecuteCommand()
        {
            commands.Last().Execute();
        }

        public void RemoveCommand()
        {
            commands.RemoveAt(commands.Count - 1);
        }
    }
}
