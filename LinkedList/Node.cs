using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        //Instance variables
        public int data;
        public Node next;
        //Constructor
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class SortedNode<T>
    {
        public T data;
        public SortedNode<T> next;

        public SortedNode(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
