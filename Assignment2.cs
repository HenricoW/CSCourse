
namespace CshIntermediate.Assignment2
{
    class Assignment2
    {
        public static StateManager? manager { get; private set; }

        public static void Run()
        {
            MainMenuState mainMenuState = new MainMenuState();
            string initCommandName = "ShowHelp";
            HelpCommand initCommand = new HelpCommand();

            manager = new StateManager(mainMenuState, initCommandName, initCommand);
            mainMenuState.SetManager(manager);

            SaveFileState saveState = new SaveFileState(manager);
            SaveFileCommand saveCommand = new SaveFileCommand(manager);
            manager.AddCommand("SaveFile", saveCommand);

            LoadFileState loadState = new LoadFileState(manager);
            LoadFileCommand loadCommand = new LoadFileCommand(manager);
            manager.AddCommand("LoadFile", loadCommand);

            StartGameState startState = new StartGameState(manager);
            StartGameCommand startCommand = new StartGameCommand(manager);
            manager.AddCommand("StartGame", startCommand);

            BackCommand backCommand = new BackCommand(manager);
            manager.AddCommand("Back", backCommand);

            manager.Run();
        }
    }
}