namespace CshIntermediate.Assignment2
{
    class LoadFileState : State
    {
        private List<FileInfo> fileList = new List<FileInfo>();
        public StateManager _manager { get; private set; }

        public LoadFileState(StateManager manager) { _manager = manager; }

        public override void Display()
        {
            // show all the available files in this directory, numbered choice
            var directory = new DirectoryInfo("./Assignment2/Files");
            fileList = directory.EnumerateFiles().ToList();

            Console.WriteLine("[Load file] - Select a file to load");
            int idx = 0;
            foreach (FileInfo file in fileList) Console.WriteLine($"{++idx} - {file.Name}");

            Console.WriteLine("[0 - Go back]");
            Console.WriteLine();
        }

        public override void GetCommand()
        {
            int fileNumber = Command.getInt("Your selection > ");
            if (fileNumber == 0)
            {
                _manager.ChangeState("Back");
                return;
            }

            if (fileNumber > 0 && fileNumber <= fileList.Count) Console.WriteLine($"Loaded \"{fileList[fileNumber - 1].Name}\"");
            else Console.WriteLine("Invalid selection");
        }
    }
}