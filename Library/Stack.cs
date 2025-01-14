using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
        public class Stack
        {
            public object[] Items;
            public int Count;

            public Stack(int capacity = 4)
            {
                Items = new object[capacity];
                Count = 0;
            }

            public void Push(object item)
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

            public object Pop()
            {
                if (Count == 0) throw new InvalidOperationException("Stack is empty.");
                return Items[--Count];
            }

            public object Peek()
            {
                if (Count == 0) throw new InvalidOperationException("Stack is empty.");
                return Items[Count - 1];
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


