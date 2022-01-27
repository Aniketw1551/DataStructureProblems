using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CustomLinkedList
    {
        public Node head;
        //Method to Add Node in Linked List
        public void AddNode(int data)
        {
            Node node = new Node(data);
            
            if (this.head == null) //condition to Check head and add first Node
            {
                this.head = node;
            }
            else
            {
                var lastNode = GetLastNode();
                lastNode.next = node;
            }
            Console.WriteLine("Inserted into node: " + node.data);
        }
        public Node GetLastNode()
        {
            //Temp Node to work
            Node temp = head;
            //Loop to check next pointer in Node
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
