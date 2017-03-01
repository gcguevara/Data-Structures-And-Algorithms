using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display list.");
                Console.WriteLine("2. Count the number of nodes.");
                Console.WriteLine("3. Search for an element.");
                Console.WriteLine("4. Insert in empty list/ insert in beginning of the linked list.");
                Console.WriteLine("5. Insert a node at the end of the list.");
                Console.WriteLine("6. Insert a node after a specificied node.");
                Console.WriteLine("7. Insert a node before a specified node.");
                Console.WriteLine("8. Insert a node at a given position.");
                Console.WriteLine("9. Delete a first node.");
                Console.WriteLine("10. Delete last node.");
                Console.WriteLine("11. Delete any node.");
                Console.WriteLine("12. Reverse the list.");
                Console.WriteLine("13. Bubble sort by exchanging data.");
                Console.WriteLine("14. Bubble sort by exchanging links.");
                Console.WriteLine("15. MergeSort.");
                Console.WriteLine("16. Insert cycle.");
                Console.WriteLine("17. Detect cycle.");
                Console.WriteLine("18. Remove cycle.");
                Console.WriteLine("19. Quit.");

                Console.WriteLine("");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (choice == 19)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.WriteLine("Enter the element to be searched : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
