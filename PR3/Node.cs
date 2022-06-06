using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    class Node<T>
    {
        public T ThisNode { get; set; }
        public Node<T> NextNode { get; set; }

    }
}
