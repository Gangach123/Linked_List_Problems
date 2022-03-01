using System;
namespace Linked_List_Problem
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Linked_List_Problems");
            Linked_List linked_List = new Linked_List();
            linked_List.CreatingElements(56);
            linked_List.CreatingElements(30);
            linked_List.CreatingElements(70);
            //Searhing for the Node
            linked_List.SearchingForNode(56);
            linked_List.DisplayLinkedList();
        }
    }
}
