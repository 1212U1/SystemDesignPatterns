//Holds the text editor changes
namespace MementoPattern
{
    public class EditorMemento
    {
        private readonly String content;
        public EditorMemento(String content)
        {
            this.content = content;
        }

        public String GetContent()
        {
            return this.content;
        }

    }
}
