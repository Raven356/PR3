using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    class LinkedList<T>:IEnumerable<T>
    {
        Node<T> _head; 
        Node<T> _tail;
        private int _count = 0;

        public void Add(T data)
        {
            Node<T> node = new Node<T> { ThisNode = data };
            if (_head == null)
                _head = node;
            else
                _tail.NextNode = node;
            _tail = node;
            _count++;
        }

        public bool Contains(T data)
        {
            int amount = 0;
            Node<T> current = _head;
            while(current != null)
            {
                if (current.ThisNode.ToString().Equals(data.ToString()))
                {
                    amount++;
                }
                current = current.NextNode;
            }
            return amount == 4;
        }

        public int Count()
        {
            return _count;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;
            while (current != null)
            {
                yield return current.ThisNode;
                current = current.NextNode;
            }
        }
    }
}

