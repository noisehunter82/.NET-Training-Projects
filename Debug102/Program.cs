﻿using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        int result = Some(6);
        Console.WriteLine(result);

        static int Some(int input) => Fibonacci(input);

        static int Fibonacci(int n)
        {
            Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
            Debug.WriteLine($"We are looking for the {n}th number");

            int n1 = 0;
            int n2 = 1;
            int sum;

            for (int i = 2; i <= n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
                Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
            }
            // If n2 is 5 continue, else break.
            //Debug.Assert(n2 == 5, "The return value is not 5 and it should be.");
            return n == 0 ? n1 : n2;
        }
    }
}