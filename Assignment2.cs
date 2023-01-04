
namespace CshIntermediate.Assignment2
{
    class Assignment2
    {
        public static StateManager? manager { get; private set; }

        public static void Run()
        {
            MainMenuState mainMenuState = new MainMenuState();
            string stateName = "MainMenu";
            HelpCommand initCommand = new HelpCommand();

            manager = new StateManager(stateName, mainMenuState, "ShowHelp", initCommand);
            mainMenuState.SetManager(manager);

            SaveFileState saveState = new SaveFileState(manager);
            SaveFileCommand saveCommand = new SaveFileCommand(manager);
            stateName = "SaveFile";
            manager.AddCommand(stateName, saveCommand);
            manager.AddState(stateName, saveState);

            LoadFileState loadState = new LoadFileState(manager);
            LoadFileCommand loadCommand = new LoadFileCommand(manager);
            stateName = "LoadFile";
            manager.AddCommand(stateName, loadCommand);
            manager.AddState(stateName, loadState);

            StartGameState startState = new StartGameState(manager);
            StartGameCommand startCommand = new StartGameCommand(manager);
            stateName = "StartGame";
            manager.AddCommand(stateName, startCommand);
            manager.AddState(stateName, startState);

            BackCommand backCommand = new BackCommand(manager);
            manager.AddCommand("Back", backCommand);

            manager.Run();
        }
    }
}