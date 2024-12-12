using System;

class Program
{
    static void Main()
    {
        // Perform the specified operations
        int result1 = -1 + 4 * 6;
        int result2 = (35 + 5) % 7;
        int result3 = 14 + -4 * 6 / 11;
        int result4 = 2 + 15 / 6 * 1 - 7 % 2;

        // Print the results
        Console.WriteLine($"Result of -1 + 4 * 6 is: {result1}");
        Console.WriteLine($"Result of (35 + 5) % 7 is: {result2}");
        Console.WriteLine($"Result of 14 + -4 * 6 / 11 is: {result3}");
        Console.WriteLine($"Result of 2 + 15 / 6 * 1 - 7 % 2 is: {result4}");
    }
}
