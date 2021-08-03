namespace AppLibrary
{
    public class NodeClass<T>
    {
        public NodeClass(T value)
        {
            this.Value = value;
        }
        public T Value { get; set; }
        public NodeClass<T> Next { get; set; }

    }

    // public class WLLNode<T>
    // {
    //     public WLLNode(T value)
    //     {
    //         this.Value = value;
    //     }
    //     public T Value { get; set; }
    //     public WLLNode<T> Next { get; set; }
    // }
}
