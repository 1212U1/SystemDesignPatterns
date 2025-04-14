namespace ProxyPattern
{
    public class HighImageResolution : IImage
    {
        private readonly String filename;
        public HighImageResolution(String filename)
        {
            this.filename = filename;
            LoadImageFromDisk();
        }
        private void LoadImageFromDisk()
        {
            Console.WriteLine("Loading image from disk");
            Thread.Sleep(5000);
        }
        public void Display()
        {
            Console.WriteLine("Displaying file");
        }

    }
}
