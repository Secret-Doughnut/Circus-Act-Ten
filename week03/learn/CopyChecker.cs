public class CopyChecker
{
    public static void Main()
    {
        List<string> strings1 = new List<string> { "a", "b", "c", "a", "d", "e", "f", "g" };

        List<string> strings2 = new List<string> { "t", "o", "b", "e", "o", "r", "n", "o", "t", "t", "o", "b", "e" };

        DuplicateChecker(strings1);
        DuplicateChecker(strings2);


    }
    
    public static void DuplicateChecker(List<string> strings)
    {

        var table = new HashSet<string>();
        string Answer = "";

        foreach (var letter in strings)
        {
            // Check if the letter exists in the hashset.
            // If not add it, otherwise, return the current letter.

            if (table.Contains(letter))
            {
                Answer = letter;
                break;
            }
            else
            {
                table.Add(letter);
            }
        }

        Console.WriteLine("There is a duplicate letter here!");
        Console.WriteLine($"The letter is: {Answer}!");

        
        // var Answer = "";

        // Dictionary<string, string> Helper_Dictionary = new Dictionary<string, string>();

        // foreach (var letter in strings)
        // {
        //     if(!Helper_Dictionary.ContainsKey(letter))
        //     {
        //         Helper_Dictionary[letter] = 1;
        //     }
        // }
        
        // Console.WriteLine($"Your list has a duplicate character. The character is: ${Answer}");
    }
}