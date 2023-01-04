namespace CshIntermediate.Assignment2
{
    class SaveFileState : State
    {
        public StateManager _manager { get; private set; }

        public SaveFileState(StateManager manager)
        {
            _manager = manager;
        }
        public override void Display()
        {
            Console.WriteLine("[Save file] - Set a name for the new file to be saved");
            Console.WriteLine("[0 - Go back]");
        }

        public override void GetCommand()
        {
            string fileName = Command.getString("Enter a file name or 0 > ");

            // handle back choice
            int number = 1;
            if (fileName.Length == 1 && int.TryParse(fileName, out number))
            {
                if (number == 0)
                {
                    _manager.ChangeState("Back");
                    return;
                }
            }

            fileName = fileName.Split(".")[0]; // if extension is given
            try
            {
                var fileHandler = File.Create($"./Assignment2/Files/{fileName}.txt");
                Console.WriteLine("File saved successfully");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Unable to save file");
                throw;
            }
        }
    }
}