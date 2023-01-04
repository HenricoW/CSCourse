namespace CshIntermediate.Assignment2
{
    class HelpCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("Help displayed!");
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
            _manager.SetState(new SaveFileState());
        }
    }

}