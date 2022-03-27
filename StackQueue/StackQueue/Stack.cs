using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Stack
    {
        LinkedList linkedList;
        public Stack()
        {
            linkedList = new LinkedList();
        }
        public void Push(Node node)
        {
            linkedList.AddNode(node);
        }
        public void Pop()
        {
            Console.WriteLine("");
            linkedList.RemoveNode();
        }
        public void DisplayStack()
        {
            //Console.WriteLine("Stack");
            linkedList.Display();
        }
        public void Top()
        {
            var val = linkedList.Head;
            Console.WriteLine(val.data);
        }
    }
}
