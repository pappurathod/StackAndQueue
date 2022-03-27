using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class Queue
    {
        LinkedList linkedList;

        public Queue()
        {
            linkedList = new LinkedList();
        }

        public void Enqueue(Node node)
        {
            linkedList.AppendNode(node);

        }
        public void DisplayQueue()
        {         
            linkedList.Display();
        }
        public void Top()
        {
            var val = linkedList.Head;
            Console.WriteLine(val);
        }
    }
}
