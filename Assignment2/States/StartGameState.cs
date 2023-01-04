namespace CshIntermediate.Assignment2
{
    class StartGameState : State
    {
        public StateManager _manager { get; private set; }

        public StartGameState(StateManager manager)
        {
            _manager = manager;
        }

        public override void Display()
        {
            Console.WriteLine("New Game started!");
            Console.WriteLine("[0 - Go back]");
        }

        public override void GetCommand()
        {
            int command = Command.getInt("Your command > ");
            switch (command)
            {
                case 0:
                    _manager.ChangeState("Back");
                    break;
                default:
                    return;
            }
        }
    }
}