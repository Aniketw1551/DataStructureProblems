using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        /// <summary>
        /// Entry point to application
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.LinkedListCall();
            SortedLinkedListCall();
            Console.ReadLine();
        }
        //Method for Sorted Linked List
        public static void SortedLinkedListCall()
        {
            SortedLinkedList<int> sortedLinkedList = new SortedLinkedList<int>();
            Console.WriteLine("SortedLinkedList\n");
            sortedLinkedList.Add(new SortedNode<int>(70));
            sortedLinkedList.Add(new SortedNode<int>(40));
            sortedLinkedList.Add(new SortedNode<int>(30));
            sortedLinkedList.Add(new SortedNode<int>(56));
            Console.WriteLine("LinkedList before sorting");
            sortedLinkedList.Display();
            sortedLinkedList.SortedList();
            Console.WriteLine("LinkedList after sorting");
            sortedLinkedList.Display();
        }
    }
}
      
