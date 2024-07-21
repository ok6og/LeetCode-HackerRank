namespace StackImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Pop());
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T value)
        {
            this.Value = value;
            Previous = null;
        }
    }
    public class Stack<T>
    {
        public Node<T>? Head { get; set; }

        public int Length { get; set; }

        public Stack()
        {
            Head = null;
            Length = 0;
        }
        public void Push(T item)
        {
            Length++;
            Node<T> newNode = new(item);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            newNode.Previous = Head;
            Head = newNode;

        }
        public T Pop()
        {
            Length = Math.Max(0, Length - 1);
            Node<T> head;
            if(Length == 0)
            {
                head = Head;
                Head = null;
                return head.Value;
            }

            head = Head;
            this.Head = head.Previous;

            return head.Value;

        }
       

        public T? Peek()
        {
            return this.Head == null ? default(T) : this.Head.Value;
        }
    }
}
