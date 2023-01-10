
namespace CshIntermediate.Assignment2
{
    // consider making static - to use as 'singleton' (will probably need initializer 'cause no constructor)
    class StateManager
    {
        // state props
        public State prevState { get; private set; }
        public State currentState { get; private set; }
        // all commands the state machine supports
        public Dictionary<string, Command> commands { get; private set; }
        public Dictionary<string, State> supportedStates { get; private set; }

        // [if not static] constructor - set init state
        public StateManager(string initStateName, State initialState, string commandName, Command initialCommand)
        {
            prevState = initialState;
            currentState = initialState;
            commands = new Dictionary<string, Command>();
            supportedStates = new Dictionary<string, State>();
            commands.Add(commandName, initialCommand);
            supportedStates.Add(initStateName, initialState);
        }

        public void Run()
        {
            Console.WriteLine();
            currentState.Display();
            currentState.GetCommand();

            // if changed to 'exit state' then allow game to end
            if (currentState.GetType() == typeof(ExitState)) return;

            // after each state completes, return to main menu
            State? state;
            if (!supportedStates.TryGetValue("MainMenu", out state)) { return; }
            SetState(state);
        }

        public void AddCommand(string commandName, Command command) { commands.Add(commandName, command); }

        public void AddState(string stateName, State state) { supportedStates.Add(stateName, state); }

        // change state method
        public bool ChangeState(string commandName)
        {
            // if command is supported, run it
            Command? command;
            if (!commands.TryGetValue(commandName, out command)) { return false; }

            // command checks if new state is supported then triggers a state change
            command.Execute();
            return true;
        }

        public void SetState(State newState)
        {
            prevState = currentState;
            currentState = newState;
            Run();
        }
    }
}