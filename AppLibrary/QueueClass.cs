using System;
namespace AppLibrary
{
    public class QueueClass<T>
    {
        public NodeClass<T> Head { get; set; }
        public NodeClass<T> Tail { get; set; }
        public int Count { get; set; }
      
       public NodeClass<T> Enqueue(T value)
        {
            NodeClass<T> node = new NodeClass<T>(value);
            // (T firstName, T lastName, T email, T favoriteFood)
            

            if (this.Head == null)
            {
                Head = Tail = node;
                this.Count++;
                return node;
            }

           this.Tail.Next = node;
           this.Tail = node;
           this.Count++;
           return node;
        }
        public T Dequeue()
        {
            if(Head== null)
            {
                throw new InvalidOperationException("Queue is empty; cannot remove from empty Queue");
            }
            T isRemoved = this.Head.Value;
            this.Head = this.Head.Next;
            this.Count--;
            return isRemoved;

        }
        public void Print()
        {
            var temp = Head;
            while (temp != null)
            {
                System.Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
       
    }
}