using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void CreateList()
        {
            Console.WriteLine("Enter the number of nodes : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter the element to be inserted : ");
                int data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }

        }

        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            Console.WriteLine("List is : ");
            p = start;
            while (p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            }
            Console.WriteLine("End of list.");
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("Number of nodes in the list = " + n);
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            
            while (p != null)
            {
                if (p.info == x)
                {
                    break;
                }
                position++;
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine(x + " was not found in the list.");
                return false;
            }
            else
            {
                Console.WriteLine(x + " is at position " + position);
                return true;
            }
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
                return;
            }

            p = start;
            while (p.link != null)
            {
                p = p.link;
            }

            p.link = temp;
        }
    }
}
