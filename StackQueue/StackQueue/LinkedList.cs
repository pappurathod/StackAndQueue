using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class LinkedList
    {
        public Node Head;
        public Node Tail;


        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void Display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine("Stack as follows");

            }
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                {
                    Console.WriteLine("");
                }
                temp = temp.next;
            }
        }
    }
}
