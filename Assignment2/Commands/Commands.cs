namespace CshIntermediate.Assignment2
{
    class HelpCommand : Command
    {
        public override void Execute() { Console.WriteLine("Help displayed!"); }
    }

    class LoadFileCommand : Command
    {
        public StateManager _manager { get; set; }

        public LoadFileCommand(StateManager manager) { _manager = manager; }

        public override void Execute()
        {
            State? state;
            if (!_manager.supportedStates.TryGetValue("LoadFile", out state)) { return; }

            _manager.SetState(state);
        }
    }

    class SaveFileCommand : Command
    {
        public StateManager _manager { get; set; }

        public SaveFileCommand(StateManager manager) { _manager = manager; }

        public override void Execute()
        {
            State? state;
            if (!_manager.supportedStates.TryGetValue("SaveFile", out state)) { return; }

            _manager.SetState(state);
        }
    }

    class StartGameCommand : Command
    {
        public StateManager _manager { get; set; }

        public StartGameCommand(StateManager manager) { _manager = manager; }

        public override void Execute()
        {
            State? state;
            if (!_manager.supportedStates.TryGetValue("StartGame", out state)) { return; }

            _manager.SetState(state);
        }
    }

    class BackCommand : Command
    {
        public StateManager _manager { get; set; }

        public BackCommand(StateManager manager) { _manager = manager; }

        public override void Execute() { _manager.SetState(_manager.prevState); }
    }

    class ExitCommand : Command
    {
        public StateManager _manager { get; set; }

        public ExitCommand(StateManager manager) { _manager = manager; }

        public override void Execute()
        {
            State? state;
            if (!_manager.supportedStates.TryGetValue("Exit", out state)) { return; }

            _manager.SetState(state);
        }
    }
}