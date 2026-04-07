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


        if (value != Data)
        {
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
        else
        {
            Console.WriteLine("You already have that value!");
            return;
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        
        bool Thing = false;

        if (value < Data && Left is not null)
        {
            // Told this to not worry about it being null.
            // Since I don't think a null value,
            // can pass the if statement.
            Thing = Left!.Contains(value);
        }
        else if (value > Data && Right is not null)
        {
            // Told this to not worry about it being null.
            // Since I don't think a null value,
            // can pass the if statement.
            Thing = Right!.Contains(value);
        }
        else if (value == Data)
        {
            return Thing = true;
        }
        else
        {
            Console.WriteLine("Can't find a match to the value requested.");
            return false;
        }

        return Thing;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}