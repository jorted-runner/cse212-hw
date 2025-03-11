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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // create a list of doubles
        List<double> result = new List<double>();

        // loop through from 1 to the length variable
        for (int i = 1; i <= length; i++) {
            // add the number * i to the list
            result.Add(number * i);
        }


        return result.ToArray();
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Find the index for where the new list will begin
        int splitIndex = data.Count - amount; 

        // Slice the list into two parts.
        //Get the new start by starting at the split index and getting the shift amount
        List<int> newStart = data.GetRange(splitIndex, amount);

        // get the remaining elements up to the split
        List<int> newEnd = data.GetRange(0, splitIndex);

        // clear out the original list. Add the new start then add the new end.
        data.Clear();
        data.AddRange(newStart);
        data.AddRange(newEnd);
    }
}
