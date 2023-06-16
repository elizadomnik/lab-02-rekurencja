using System;

class zad6
{
    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Wprowadź liczbę x: ");
        int x = int.Parse(Console.ReadLine());

        int n = 0;
        while (Factorial(n) <= x)
        {
            if (Factorial(n) == x)
            {
                Console.WriteLine($"Liczba {x} jest silnią liczby {n}.");
                return;
            }
            n++;
        }

        Console.WriteLine($"Liczba {x} nie jest silnią żadnej liczby.");
    }
}

