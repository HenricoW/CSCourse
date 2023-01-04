namespace CshIntermediate.Assignment2
{
    class HelpCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("Help displayed!");
        }
    }

    class LoadFileCommand : Command
    {
        public StateManager _manager { get; set; }

        public LoadFileCommand(StateManager manager)
        {
            _manager = manager;
        }

        public override void Execute()
        {
            _manager.SetState(new LoadFileState(_manager));
        }
    }

    class SaveFileCommand : Command
    {
        public StateManager _manager { get; set; }

        public SaveFileCommand(StateManager manager)
        {
            _manager = manager;
        }

        public override void Execute()
        {
            _manager.SetState(new SaveFileState(_manager));
        }
    }

    class StartGameCommand : Command
    {
        public StateManager _manager { get; set; }

        public StartGameCommand(StateManager manager)
        {
            _manager = manager;
        }

        public override void Execute()
        {
            _manager.SetState(new StartGameState(_manager));
        }
    }

    class BackCommand : Command
    {
        public StateManager _manager { get; set; }

        public BackCommand(StateManager manager)
        {
            _manager = manager;
        }

        public override void Execute()
        {
            _manager.SetState(_manager.prevState);
        }
    }
}