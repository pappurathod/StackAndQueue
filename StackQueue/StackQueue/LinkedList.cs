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
        public void RemoveNode()
        {
            while (Head != null)
            {
                Console.WriteLine("pop = {0}",Head.data);
                Head = Head.next;
            }
        }
        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }
        public void Display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("Now Stack is empty");
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
