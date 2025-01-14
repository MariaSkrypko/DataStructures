namespace Library
{
        public class List
        {
            public object[] items;
            public int count;

            public List(int capacity = 4)
            {
                items = new object[capacity];
                count = 0;
            }

            public object this[int index]
            {
                get
                {
                    if (index < 0 || index >= count)
                        throw new IndexOutOfRangeException();
                    return items[index];
                }
                set
                {
                    if (index < 0 || index >= count)
                        throw new IndexOutOfRangeException();
                    items[index] = value;
                }
            }

            public void Add(object item)
            {
                if (count == items.Length)
                {
                    var newItems = new object[items.Length * 2];
                    for (int i = 0; i < count; i++)
                        newItems[i] = items[i];
                    items = newItems;
                }

                items[count++] = item;
            }

            public void Clear()
            {
                items = new object[4];
                count = 0;
            }

            public bool Contains(object item)
            {
                for (int i = 0; i < count; i++)
                {
                    if (items[i].Equals(item))
                        return true;
                }
                return false;
            }
        }
    }



