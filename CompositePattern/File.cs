namespace CompositePattern
{
    public class File : FileSystemComponent
    {
        private readonly String fileName;
        public File(String fileName)
        {
            this.fileName = fileName;

        }
        public void Details()
        {
            Console.WriteLine("File name: " + this.fileName);
        }
    }
}
