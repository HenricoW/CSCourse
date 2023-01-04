
namespace CshIntermediate.Assignment2
{
    class Assignment2
    {
        public static StateManager? manager { get; private set; }

        public static void Run()
        {
            // define all states and commands once, to used throughout app
            string stateName = "MainMenu";
            MainMenuState mainMenuState = new MainMenuState();
            manager = new StateManager(stateName, mainMenuState, "ShowHelp", new HelpCommand());
            mainMenuState.SetManager(manager);

            stateName = "SaveFile";
            manager.AddCommand(stateName, new SaveFileCommand(manager));
            manager.AddState(stateName, new SaveFileState(manager));

            stateName = "LoadFile";
            manager.AddCommand(stateName, new LoadFileCommand(manager));
            manager.AddState(stateName, new LoadFileState(manager));

            stateName = "StartGame";
            manager.AddCommand(stateName, new StartGameCommand(manager));
            manager.AddState(stateName, new StartGameState(manager));

            manager.AddCommand("Back", new BackCommand(manager));

            manager.AddCommand("Exit", new ExitCommand(manager));
            manager.AddState("Exit", new ExitState(manager));

            manager.Run();
        }
    }
}