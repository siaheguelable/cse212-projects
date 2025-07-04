public static class Sorting
{
    public static void Run()
    {
        var numbers = new[] { 3, 2, 1, 6, 4, 9, 8 };
        SortArray(numbers);
        Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //int[]{1, 2, 3, 4, 6, 8, 9}
    }

    private static void SortArray(int[] data)
    {
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--)
        {
            for (var swapPos = 0; swapPos < sortPos; ++swapPos)
            {
                if (data[swapPos] > data[swapPos + 1])
                {
                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]);
                }
            }
        }
    }
    // O(n^2) time complexity
    // The outer loop runs n times, and for each iteration of the outer loop,
    // the inner loop runs n times as well. Therefore, the total number of iterations is n * n = n^2.
    // but if one loop does not depend on the other, it is O(n) time complexity
}