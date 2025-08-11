public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1



        if (value < Data)
        {


            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }

        else
        // value == this.Value → duplicate, so do nothing
        {
            return;
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        if (value==data)
        //If they are equal → return true (found it)
        {
            return true;
        }

        if (value< data)
        //If the target is less than the current node’s value → search left.
        {
            // search to the left
            if (Left!=null )
        
                return left.Contains(value);
            
            else
            
                return false; // // No left child, not found
        }

       else
       {
         // Go right if possible
        if (this.Right != null)
            return this.Right.Contains(value);
        else
            return false; // No right child, not found

       }

        
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}