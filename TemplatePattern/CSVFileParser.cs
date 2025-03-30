namespace TemplatePattern
{
    public class CSVFileParser : ParseFiles
    {
        protected override void ParserFileLogic()
        {
            Console.WriteLine("Parsed CSV successfully");
        }
    }
}
