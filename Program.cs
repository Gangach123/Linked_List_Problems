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
            linked_List.CreatingElements(70);
            //Adding Node of 30 between 56 & 70.
            linked_List.AddingElementBetweenNodes(30);
            //Verifying if UC Purpose id filled or not!
            linked_List.DisplayLinkedList();
        }
    }
}
