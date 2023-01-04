
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

            SaveFileState saveState = new SaveFileState();
            SaveFileCommand saveCommand = new SaveFileCommand(manager);
            manager.AddCommand("SaveFile", saveCommand);

            LoadFileState loadState = new LoadFileState();
            LoadFileCommand loadCommand = new LoadFileCommand(manager);
            manager.AddCommand("LoadFile", loadCommand);

            manager.Run();
        }
    }
}