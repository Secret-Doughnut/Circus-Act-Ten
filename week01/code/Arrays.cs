public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Make a counter variable and a double data type array. 
        // Set the length to the length argument.
        double[] Times_Table = new double[length];
        int Counter = 0;

        // Make a while loop that compares the counter variable with the length variable.
        // Have the loop repeat itself, until you have the amount of numbers that the variable length is.
        //Like, if "length" is 5, you need 5 different ints.
        
        //Inside of the while loop mentioned above, have the counter variable be multiplied
        // by the number argument (of this function). Add the results to the array, which was
        // created earlier.
        while (Counter != length)
        {
            Counter += 1;
            double Placeholder = Counter * number;
            Times_Table[Counter - 1] = Placeholder;
        }

        return Times_Table;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Create a new list and a Counter variable.
        // List<int> Numbers = new List<int>();
        // int Counter = 1;

        // // Create a foreach loop that goes through all of the items in the list named "data".
        // // Have an if statement, that asks if the Counter variable is the same as the "amount" variable.
        // // Inside of the if statement, add the numbers that enter it, into the new list created above.
        // foreach (int number in data)
        // {
        //     if (Counter >= amount)
        //     {
        //         Numbers.Add(number);
        //     }

        //     Counter += 1;
        // }

        // Counter = 1;

        // //  Have another foreach loop that goes through "data".
        // // This loop has an if statement that grabs all of the numbers LOWER then "amount".
        // // And adds those to the same list.
        // foreach (int thing in data)
        // {
        //     if (Counter < amount)
        //     {
        //         Numbers.Add(thing);
        //     }

        //     Counter += 1;
        // }

        // // Clear out the old list, so we can copy the new list order back into it.
        // data.Clear();


        // // Use a foreach loop to copy the data from the new list and transfer it to the "data" list.
        // foreach (int item in Numbers)
        // {
        //     data.Add(item);
        // }

    }
}
