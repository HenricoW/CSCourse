namespace CshIntermediate.Assignment2 {
    abstract class State {
        // display on screen and show supported commands
        abstract public void Display();

        // accept command, trigger command object
        abstract public void GetCommand();
    }

    abstract class Command {
        // helpers
        static public string getString(string prompt){
            Console.Write(prompt);
            var input  = Console.ReadLine();

            return input == null ? "" : input;
        }

        static public int getInt(string prompt){
            Console.Write(prompt);
            var input  = Console.ReadLine();

            return input == null ? 0 : int.Parse(input);
        }

        // command to change state
        abstract public void Execute();
    }
}