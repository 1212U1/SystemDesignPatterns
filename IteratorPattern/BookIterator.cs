namespace IteratorPattern
{
    public class BookIterator : IIterator<Book>
    {
        private int position;
        private readonly int count;
        private readonly List<Book> collection;
        public BookIterator(BookCollection bookCollection)
        {
            this.collection = bookCollection.GetBooks();
            count = bookCollection.GetBooks().Count;
        }
        bool IIterator<Book>.HasNext()
        {
            return position < count;
        }
        Book IIterator<Book>.Next()
        {
            return this.collection[position++];
        }
    }
}
