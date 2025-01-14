using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Queue
    {
        public class Node
        {
            public object Value;
            public Node Next;

            public Node(object value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node _head;
        private Node _tail;
        public int Count;

        public Queue()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public void Enqueue(object value)
        {
            var newNode = new Node(value);

            if (_tail != null)
            {
                _tail.Next = newNode;
            }

            _tail = newNode;

            if (_head == null)
            {
                _head = newNode;
            }

            Count++;
        }

        public object Dequeue()
        {
            if (_head == null)
                throw new InvalidOperationException("Queue is empty.");

            var value = _head.Value;
            _head = _head.Next;

            if (_head == null)
            {
                _tail = null;
            }

            Count--;
            return value;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public bool Contains(object value)
        {
            var current = _head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public object Peek()
        {
            if (_head == null)
                throw new InvalidOperationException("Queue is empty.");

            return _head.Value;
        }

        public object[] ToArray()
        {
            var result = new object[Count];
            var current = _head;
            for (int i = 0; i < Count; i++)
            {
                result[i] = current.Value;
                current = current.Next;
            }
            return result;
        }
    }
}
