namespace ProxyPattern
{
    public class ImageProxy : IImage
    {
        private readonly String filename;
        private IImage realImage;
        public ImageProxy(String filename)
        {
            this.filename = filename;
        }
        public void Display()
        {
            if (realImage == null)
            {
                realImage = new HighImageResolution(filename);
            }
            realImage.Display();
        }
    }
}
