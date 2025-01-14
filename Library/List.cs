namespace Library
{
        public class List
        {
            public object[] Items;
            public int Count;

            public List(int capacity = 4)
            {
                Items = new object[capacity];
                Count = 0;
            }

            public object this[int index]
            {
                get
                {
                    if (index < 0 || index >= Count)
                        throw new IndexOutOfRangeException();
                    return Items[index];
                }
                set
                {
                    if (index < 0 || index >= Count)
                        throw new IndexOutOfRangeException();
                    Items[index] = value;
                }
            }

            public void Add(object item)
            {
                if (Count == Items.Length)
                {
                    var newItems = new object[Items.Length * 2];
                    for (int i = 0; i < Count; i++)
                        newItems[i] = Items[i];
                    Items = newItems;
                }

                Items[Count++] = item;
            }

            public void Clear()
            {
                Items = new object[4];
                Count = 0;
            }

            public bool Contains(object item)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (Items[i].Equals(item))
                        return true;
                }
                return false;
            }
        }
    }



