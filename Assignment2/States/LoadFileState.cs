namespace CshIntermediate.Assignment2
{
    class LoadFileState : State
    {
        private List<FileInfo> fileList = new List<FileInfo>();

        public override void Display()
        {
            // show all the available files in this directory, numbered choice
            var directory = new DirectoryInfo("./Assignment2/Files");
            fileList = directory.EnumerateFiles().ToList();

            Console.WriteLine("[Load file] - Select a file to load");
            int idx = 0;
            foreach (FileInfo file in fileList)
            {
                Console.WriteLine($"{++idx} - {file.Name}");
            }
            Console.WriteLine();
        }

        public override void GetCommand()
        {
            int fileNumber = Command.getInt("Your selection > ");
            if (fileNumber > 0 && fileNumber <= fileList.Count) Console.WriteLine($"Loaded \"{fileList[fileNumber - 1].Name}\"");
            else Console.WriteLine("Invalid selection");
        }
    }
}