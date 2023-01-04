namespace CshIntermediate.Assignment2
{
    class StartGameState : State
    {
        public override void Display()
        {
            Console.WriteLine("New Game started!");
        }

        public override void GetCommand()
        {
            return;
        }
    }
}