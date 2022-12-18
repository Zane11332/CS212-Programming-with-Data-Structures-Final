namespace tree_solution;

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
        if (Contains(value))
            return;
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (Data == value)
            return true;

        if (value < Data)
        {
            if (Left is null)
                return false;
            return Left.Contains(value);
        }
        else
        {
            if (Right is null)
                return false;
            return Right.Contains(value);
        }

        return false;
    }
    
    public int GetHeight(int height = 1, int totalHeight = 0)
    {
        if (Left != null){
            totalHeight = Left!.GetHeight(height + 1, totalHeight);}

        if (totalHeight < height){
            totalHeight = height;}
        
        if (Left == null && Right == null){
            return totalHeight;}

        if (Right != null){
            return Right.GetHeight(height + 1, totalHeight);}
        else{
            return Left!.GetHeight(height + 1, totalHeight);}
    }
}