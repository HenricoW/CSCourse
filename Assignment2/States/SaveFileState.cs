namespace CshIntermediate.Assignment2
{
    class SaveFileState : State
    {
        public override void Display()
        {
            Console.WriteLine("[Save file] - Set a name for the new file to be saved");
        }

        public override void GetCommand()
        {
            string fileName = Command.getString("Enter a file name > ");
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