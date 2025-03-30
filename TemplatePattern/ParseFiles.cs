namespace TemplatePattern
{
    public abstract class ParseFiles
    {
        public void ParseFile()
        {
            OpenFile();
            ParserFileLogic();
            CloseFile();
        }
        protected void OpenFile()
        {
            Console.WriteLine("Opening the file");
        }
        protected void CloseFile()
        {
            Console.WriteLine("Closing the file");
        }
        protected abstract void ParserFileLogic();

    }
}
