using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

namespace QueueImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Deque();
            queue.Deque();
            Console.WriteLine(queue.Deque());
        }


    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
            Next = null;
        }
    }

    public class Queue<T>
    {
        public Node<T>? Head { get; set; }
        public Node<T>? Tail { get; set; }

        public int Length { get; set; }

        public Queue()
        {
            this.Head = this.Tail = null;
            this.Length = 0;
        }

        public void Enqueue(T item)
        {
            Length++;
            Node<T> newNode = new(item);
            
            if (Tail == null)
            {
                Tail = Head = newNode;
                return;
            }

            Tail.Next = newNode;

            Tail = newNode;

        }

        public T Deque()
        {
            if (this.Head == null)
            {
                return default(T);
            }

            Length--;
            var head = Head;
            this.Head = this.Head.Next;

            return head.Value;
        }

        public T Peek() 
        {
            if (this.Head.Value != null)
            {
                return this.Head.Value;
            }
            return default(T);
        }
    }
}
