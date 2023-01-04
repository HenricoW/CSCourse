namespace CshIntermediate.Assignment2
{
    class MainMenuState : State
    {
        public StateManager? _manager { get; private set; }

        public override void Display()
        {
            string prompt = "Choose your command\n";
            prompt += "L - load a new file\n";
            prompt += "S - Save a file\n";
            prompt += "N - Start a new game\n";
            prompt += "H - Display the help\n";

            Console.WriteLine(prompt);
        }

        public void SetManager(StateManager manager)
        {
            _manager = manager;
        }

        public override void GetCommand()
        {
            if (_manager == null)
            {
                Console.WriteLine("Manager not set. Set manager first");
                return;
            }

            bool validCommand = false;
            while (!validCommand)
            {
                string command = Command.getString("Your command: ");

                switch (command)
                {
                    case "L":
                        validCommand = _manager.ChangeState("LoadFile");
                        break;
                    case "S":
                        validCommand = _manager.ChangeState("SaveFile");
                        break;
                    case "N":
                        validCommand = _manager.ChangeState("StartGame");
                        break;
                    case "H":
                        validCommand = _manager.ChangeState("ShowHelp");
                        break;
                    default:
                        break;
                }

                if (!validCommand) Console.WriteLine("Command not supported, please try another");
            }
        }
    }
}