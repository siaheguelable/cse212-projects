/// <summary>
/// These 3 functions will (in different ways) calculate the standard
/// deviation from a list of numbers.  The standard deviation
/// is defined as the square root of the variance.  The variance is 
/// defined as the average of the squared differences from the mean.
/// </summary>
public static class StandardDeviation
{
    public static void Run()
    {
        var numbers = new[] { 600, 470, 170, 430, 300 };
        Console.WriteLine(StandardDeviation1(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation2(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation3(numbers)); // Should be 147.322 
    }

    private static double StandardDeviation1(int[] numbers)
    {
        var total = 0.0;
        var count = 0;
        foreach (var number in numbers)
        {
            total += number;
            count += 1;
            // O(n) time complexity
            // The loop iterates through each element in the array exactly once,
            // so the time complexity is O(n).
        }

        var avg = total / count;
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers)
        {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
            // O(n) time complexity
            // The loop iterates through each element in the array exactly once,
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
        // the first loop runs n times, and the second loop also runs n times,
        // and the loops are independent of each other, so the overall time complexity is O(n + n) = O(n).
        // O(n) time complexity


    }

    private static double StandardDeviation2(int[] numbers)
    {
        var sumSquaredDifferences = 0.0;
        var countNumbers = 0;
        foreach (var number in numbers)
        {
            // O(n) time complexity 
            // The loop iterates through each element in the array exactly once,
            // so the time complexity is O(n).
            var total = 0;
            var count = 0;
            foreach (var value in numbers)
            {
                total += value;
                count += 1;
                // O(n) time complexity
                // The loop iterates through each element in the array exactly once,
            }

            var avg = total / count;
            sumSquaredDifferences += Math.Pow(number - avg, 2);
            countNumbers += 1;
        }

        var variance = sumSquaredDifferences / countNumbers;
        return Math.Sqrt(variance);

        // O(n^2) time complexity
        // The outer loop runs n times, and for each iteration of the outer loop,
        // the inner loop runs n times as well. Therefore, the total number of iterations is n * n = n^2.
    }

    private static double StandardDeviation3(int[] numbers)
    {
        var count = numbers.Length;
        var avg = (double)numbers.Sum() / count;
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers)
        {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }
    
    // O(n) time complexity
    // The loop iterates through each element in the array exactly once,
}