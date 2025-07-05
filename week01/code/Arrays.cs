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
      // Step 1: Create a list or array to store the multiples (we don't know exact size for list, or use array of size 'count').

// Step 2: Loop from 1 to 'count'.
// For each iteration:
// - Compute the multiple by multiplying the number by the current index (e.g., number * i).

// Step 3: Add the multiple to the list or assign to array position.

// Step 4: After the loop, return the list converted to array (if using list) or return the array.



        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;
   
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
        // Step 1: Determine where to "cut" the list for rotation.
        // Since we're rotating to the right, we want the last 'amount' elements to move to the front.

        // Step 2: Use GetRange to get the last 'amount' elements of the list.
        // Example: If amount is 3, get elements at index Count - 3 to end.

        // Step 3: Use GetRange to get the remaining elements (from start up to Count - amount).

        // Step 4: Clear the original list (or overwrite it).

        // Step 5: Add the rotated elements first (the slice from the end).
        // Then add the rest of the elements (the slice from the start).

        // Step 6: Done! The list is now rotated to the right by 'amount'.

        List<int> rotated = data.GetRange(data.Count - amount, amount);
        rotated.AddRange(data.GetRange(0, data.Count - amount));
        data.Clear();
        data.AddRange(rotated);
    }
}



        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

