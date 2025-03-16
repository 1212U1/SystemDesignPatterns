namespace MementoPattern
{
    public class TextEditor
    {
        private String content;

        public TextEditor(String content)
        {
            this.content = content;
        }
        public String Content { get => content; set => content = value; }

        public EditorMemento Save()
        {
            return new EditorMemento(content);
        }
        public void RestorePreviousValue(EditorMemento editorMemento)
        {
            content = editorMemento.GetContent();
        }
    }
}
