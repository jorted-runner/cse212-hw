using System.ComponentModel.DataAnnotations;

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
        if (value == Data) {
            return;
        }

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
        // TODO Start Problem 2
        if (Data == value) {
            return true;
        }
        if (Right is not null) {
            if (Right.Contains(value)) {
                return true;
            }
        }
        if (Left is not null) {
            if (Left.Contains(value)) {
                return true;
            }
        }
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (Right is null && Left is null) {
            return 1;
        }
        if (Left is null) {
            return 1 + Right!.GetHeight();
        }
        if (Right is null) {
            return 1 + Left.GetHeight();
        }
        return 1 + Math.Max(Right!.GetHeight(), Left!.GetHeight());
    }
}