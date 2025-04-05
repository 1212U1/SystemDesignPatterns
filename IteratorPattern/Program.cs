using IteratorPattern;

BookCollection bookCollection = new BookCollection();
bookCollection.AddBooks(new Book("C++"));
bookCollection.AddBooks(new Book("Java"));

IIterator<Book> iterator = bookCollection.GetIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next().BookName);
}