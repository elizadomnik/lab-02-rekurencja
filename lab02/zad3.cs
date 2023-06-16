using System;

public class zad3
{
    public static void Main(string[] args)
    {
        int n, k;

        n = ValidateInput("Podaj liczbę wyższą lub równa dla n:", 5);
        k = ValidateInput("Podaj liczbę wyższą lub równa dla k:", 5);


        int m = (Factorial(n) - Factorial(k)) / Factorial(k);
        Console.WriteLine(m);
    }

    private static int Factorial(int n)
    {
        if (n < 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    private static int ValidateInput(string message, int minValue)
    {
        int number;

        do
        {
            Console.Write(message);
            if (!int.TryParse(Console.ReadLine(), out number) || number < minValue)
            {
                Console.WriteLine("Podana liczba jest mniejsza niż  " + minValue + ". Spróbuj ponownie.");
            }

        } while (number < minValue);

        return number;
    }
}
