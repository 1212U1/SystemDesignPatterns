namespace CompositePattern
{
    public class Folder : FileSystemComponent
    {
        List<FileSystemComponent> components;
        private readonly String folderName;
        public Folder(String folderName)
        {
            this.folderName = folderName;
            this.components = new List<FileSystemComponent>();
        }
        public void AddComponents(FileSystemComponent component)
        {
            this.components.Add(component);
        }
        public void Details()
        {
            Console.WriteLine("Folder name: " + folderName);
            foreach (FileSystemComponent component in components)
            {
                component.Details();
            }
        }
    }
}
