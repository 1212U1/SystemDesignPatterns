namespace TemplatePattern
{
    public class JsonFileParser : ParseFiles
    {
        protected override void ParserFileLogic()
        {
            Console.WriteLine("Parsed JSON successfully");
        }
    }
}
