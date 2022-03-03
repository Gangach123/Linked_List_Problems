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
        public void SortedLink()
        {
            Node prev = head;
            int nodeData;
            while (prev != null)
            {
                Node temp = prev;
                while (temp != null)
                {
                    if (prev.data.CompareTo(temp.data) > 0)
                    {
                        nodeData = prev.data;
                        prev.data = temp.data;
                        temp.data = nodeData;
                    }
                    temp = temp.next;
                }
                prev = prev.next;
            }
        }
        //Inserting Node after a given node.
        public void InsertNodeAfterDefiningNode(int data, int definedNode)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            else
            {
                Node temp = head;
                Node prev = head;
                while (temp != null)
                {
                    if (temp.data == definedNode)
                    {
                        newNode.next = temp.next;
                        break;
                    }
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void SearchingForNode(int data)
        {
            if (head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            else
            {
                Node temp = head;
                int positionOfSearchedNode = 0;
                while (temp != null)
                {
                    positionOfSearchedNode++;
                    if (temp.data == data)
                    {
                        Console.WriteLine($"Your {data} node is found at {positionOfSearchedNode} position.");
                        break;
                    }
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine($"Specified {data} node is not present in the linked list.");
                }
            }

        }
        //To remove last node in linkedlist
        public void LastElement()
        {
            if (head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            else
            {
                Node temp = head;
                Node prev = head;
                while (temp.next != null)
                {
                    prev = temp;
                    temp = temp.next;
                }
                prev.next = null;
            }
        }
        //To delete first emelent in the list.
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            else
            {
                head = head.next;
            }
        }

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
