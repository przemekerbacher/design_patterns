namespace Iterator
{
    public class ListTraversal<T> : TraversalAbstraction
    {
        private int _index;
        private T[] _list;

        public ListTraversal(T[] list)
        {
            _list = list;
        }

        public bool HasNext()
        {
            if (_index < _list.Length)
            {
                return true;
            }

            return false;
        }

        public object Next()
        {
            return _list[_index++];
        }
    }
}
