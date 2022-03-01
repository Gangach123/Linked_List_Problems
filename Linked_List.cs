using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Problem
{
    internal class Linked_List
    {
        public Node head;

        //To Creating elements to the list
        public void CreatingElements(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;

            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;

            }
        }
        public void DisplayLinkedList()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    Console.WriteLine($"{temp.data}");
                    temp = temp.next;
                }
                Console.WriteLine($"{temp.data}");
            }
        }
        //Adding between two nodes.Works for only three elements in linked list.
        public void AddingElementBetweenNodes(int data)
        {
            Node newNode = new Node(data);
            Node temp = head;
            temp = temp.next;
            newNode.next = temp;
            head.next = newNode;
        }
    }
}
