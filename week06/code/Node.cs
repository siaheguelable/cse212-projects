public class Node
{
    public int Data { get; set; }
    public Node? Right { get; set; }
    public Node? Left { get; set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // value == Data → duplicate, so do nothing
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }
        if (value < Data)
        {
            // search to the left
            if (Left != null)
                return Left.Contains(value);
            else
                return false; // No left child, not found
        }
        else
        {
            // Go right if possible
            if (Right != null)
                return Right.Contains(value);
            else
                return false; // No right child, not found
        }
    }

    public int GetHeight()
    {
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}