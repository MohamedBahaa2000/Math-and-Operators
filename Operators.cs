using System;

class Program
{
    static void Main()
    {
        // Declare three integer variables
        int a = 10;
        int b = 20;
        int c = 30;

        // Compare the integers using complex expressions
        bool result1 = (a + b > c) && (b < a + c);
        bool result2 = (a * b <= c) || (b - a == c - a);
        bool result3 = (a == b) && (b != c) || (c > a + b);
        bool result4 = (a * c > b * c) && (b + a != c) || (a == 10);
        bool result5 = (a + b - c == 0) && (a != b || c % 5 == 0);

        // Print the comparison results
        Console.WriteLine($"Comparison 1 (a + b > c) && (b < a + c): {result1}");
        Console.WriteLine($"Comparison 2 (a * b <= c) || (b - a == c - a): {result2}");
        Console.WriteLine($"Comparison 3 (a == b) && (b != c) || (c > a + b): {result3}");
        Console.WriteLine($"Comparison 4 (a * c > b * c) && (b + a != c) || (a == 10): {result4}");
        Console.WriteLine($"Comparison 5 (a + b - c == 0) && (a != b || c % 5 == 0): {result5}");
    }
}
