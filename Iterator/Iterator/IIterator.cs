namespace Iterator
{
    public interface IIterator
    {
        MenuItem GetNext();
        bool HasNext();
    }
}