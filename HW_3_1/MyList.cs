namespace HW_3_1
{
     public  MyList<T>
    {
        private T[] _list;
        private int _length;
        public MyList()
        {
            _list = new T[0];
            _length = 0;
        }
        public MyList(int length)
        {
            _length = length;
            _list = new T[length];
        }
        public MyList<T> Add(T item)
        {
            if (_length == 0)
            {
                _list = new T[1] { item };
                _length = 1;
                return this;
            }

            T[] newList = new T[_length + 1];
            for (int i = 0; i < _length; i++)
            {
                newList[i] = _list[i];
            }

            newList[newList.Length - 1] = item;
            _list = newList;
            _length += 1;
            return this;
        }

        public void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            foreach (var item in items)
                collection.Add(item);
        }



    }
}