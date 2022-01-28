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
        /// Entry point
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.LinkedListCall();
            SortedLinkedListCall();
            Console.ReadLine();
        }

        public void LinkedListCall()
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddLastNode(56);
            customLinkedList.AddLastNode(30);
            customLinkedList.AddLastNode(40);
            customLinkedList.AddLastNode(70);
            customLinkedList.DisplayLinkedList();
            Console.WriteLine("----------------");
            int key = customLinkedList.SearchNode(40);
            customLinkedList.DeleteAtDesiredPosition(key);
            customLinkedList.DisplayLinkedList();
            customLinkedList.Size();
        }
        //Sorted Linked List 
        public static void SortedLinkedListCall()
        {
            SortedLinkedList<int> sortedLinkedList = new SortedLinkedList<int>();
            Console.WriteLine("SortedLinkedList");
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
