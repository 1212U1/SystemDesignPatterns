namespace IteratorPattern
{
    public class BookCollection
    {
        List<Book> books;
        public BookCollection()
        {
            books = new List<Book>();
        }
        public void AddBooks(Book book)
        {
            books.Add(book);
        }
        public List<Book> GetBooks() { return books; }
        public IIterator<Book> GetIterator()
        {
            return new BookIterator(this);
        }
    }
}
