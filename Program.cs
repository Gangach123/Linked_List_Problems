using System;
namespace Linked_List_Problem
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Linked_List_Problems");
            Linked_List linked_List = new Linked_List();
            linked_List.CreatingElements(70);
            linked_List.InsertingElements(30);
            linked_List.InsertingElements(56);
            linked_List.DisplayLinkedList();
        }
    }
}
