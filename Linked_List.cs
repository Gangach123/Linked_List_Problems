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
    }
}
