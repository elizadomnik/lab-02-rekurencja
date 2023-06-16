using System;

public class zad2
{
    public static void Main()
    {
        int n = 10; // Liczba kolejnych wyrazów do wygenerowania
        Console.WriteLine("Ciąg Fibonacciego:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }

    private static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

