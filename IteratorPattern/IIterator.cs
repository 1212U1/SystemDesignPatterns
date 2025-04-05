namespace IteratorPattern
{
    public interface IIterator<T>
    {
        Boolean HasNext();
        T Next();
    }
}
