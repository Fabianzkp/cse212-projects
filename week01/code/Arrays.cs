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

        // Step 1: Create a new array to store the multiples
        double[] multiples = new double[length];

        // Step 2: Use a loop to calculate and store the multiples
        for (int i = 0; i < length; i++)
        {
            // Calculate the multiple and assign it to the array
            multiples[i] = number * (i + 1);
        }

        // Step 3: Return the populated array
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Validate input
        if (data == null || data.Count == 0)
        {
            throw new ArgumentException("The list cannot be null or empty.");
        }
        if (amount < 1 || amount > data.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be between 1 and the size of the list.");
        }

        // Step 2: Calculate effective rotation
        amount = amount % data.Count; // Handles cases where amount is greater than the list size

        // Step 3: Perform rotation
        // Create slices
        var rightSlice = data.GetRange(data.Count - amount, amount);
        var leftSlice = data.GetRange(0, data.Count - amount);

        // Step 4: Update the original list
        data.Clear();
        data.AddRange(rightSlice);
        data.AddRange(leftSlice);
    }
}
