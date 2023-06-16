using System;

class zad7
{
    static void Main()
    {
        Console.Write("Wprowadź liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Pary liczb o sumie {n}:");
        FindNumberPairs(n, 1, 2);
    }

    static void FindNumberPairs(int n, int a, int b)
    {
        if (a > n / 2)
            return;

        if (a + b == n)
            Console.WriteLine($"({a}, {b})");

        if (b < n - a)
            FindNumberPairs(n, a, b + 1);
        else
            FindNumberPairs(n, a + 1, a + 2);
    }
}

