namespace StackQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Node node_1 = new Node(56);
            Node node_2 = new Node(30);
            Node node_3 = new Node(70);

            //Stack stack = new Stack();  //Stack
            //stack.Push(node_1);
            //stack.Push(node_2);
            //stack.Push(node_3);
            //stack.DisplayStack();
            //stack.Pop();
            //stack.DisplayStack();

            Queue queue = new Queue();  //Queue
            queue.Enqueue(node_1);
            queue.Enqueue(node_2);
            queue.Enqueue(node_3);
            queue.DisplayQueue();
            queue.Dequeue();
            queue.DisplayQueue();

        }
    }
}