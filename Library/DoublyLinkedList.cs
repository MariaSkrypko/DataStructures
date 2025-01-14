using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Library
{
    public class DoublyLinkedList
    {
        
        public class Node
        {
            public object Value;
            public Node Next;
            public Node Prev;

            public Node(object value)
            {
                Value = value;
                Next = null;
                Prev = null;
            }
        }

        public Node Head;
        public Node Tail;
        public int Count;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

      
        public void Add(object value)
        {
            var newNode = new Node(value);

            if (Tail != null)
            {
                Tail.Next = newNode;
                newNode.Prev = Tail; 
            }

            Tail = newNode;

            if (Head == null)
            {
                Head = newNode;
            }

            Count++;
        }

        
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

      
        public bool Contains(object value)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public object[] ToArray()
        {
            var result = new object[Count];
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                result[i] = current.Value;
                current = current.Next;
            }
            return result;
        }
    }
}
