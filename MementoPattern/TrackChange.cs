namespace MementoPattern
{
    public class TrackChange
    {
        private readonly Stack<EditorMemento> strings = new Stack<EditorMemento>();
        public TrackChange() { }

        public void SaveChanges(TextEditor editor)
        {
            strings.Push(editor.Save());
        }
        public void RestoreChanges(TextEditor editor)
        {
            if (strings.Count > 0)
            {
                strings.Pop();
                editor.RestorePreviousValue(strings.Peek());
            }
        }
    }
}
