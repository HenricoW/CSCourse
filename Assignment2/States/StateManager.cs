
namespace CshIntermediate.Assignment2
{
    // consider making static - to use as 'singleton' (will probably need initializer 'cause no constructor)
    class StateManager
    {
        // state props
        public State currentState { get; private set; }
        // all commands the state machine supports
        public Dictionary<string, Command> commands { get; private set; }

        // [if not static] constructor - set init state
        public StateManager(State initialState, string commandName, Command initialCommand)
        {
            currentState = initialState;
            commands = new Dictionary<string, Command>();
            commands.Add(commandName, initialCommand);
        }

        public void Run()
        {
            Console.WriteLine();
            currentState.Display();
            currentState.GetCommand();
        }

        public void AddCommand(string commandName, Command command)
        {
            commands.Add(commandName, command);
        }

        // change state method
        public bool ChangeState(string commandName)
        {
            Command? command;
            if (!commands.TryGetValue(commandName, out command)) { return false; }

            command.Execute();
            return true;
        }

        public void SetState(State newState)
        {
            currentState = newState;
            Run();
        }
    }
}