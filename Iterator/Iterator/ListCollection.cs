namespace Iterator
{
    public class ListCollection<T> : Collection
    {
        private T[] _list;
        public ListCollection(T[] list)
        {
            _list = list;
        }

        public TraversalAbstraction CreateIterator()
        {
            return new ListTraversal<T>(_list);
        }
    }
}
