namespace CshIntermediate.Assignment2
{
    class ExitState : State
    {
        public StateManager _manager { get; set; }

        public ExitState(StateManager manager) { _manager = manager; }

        public override void Display() { return; }
        public override void GetCommand() { return; }
    }
}