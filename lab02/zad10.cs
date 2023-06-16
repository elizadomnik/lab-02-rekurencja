using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę naturalną:");
        int number = int.Parse(Console.ReadLine());

        if (number < 100)
        {
            Console.WriteLine("Podana liczba musi mieć co najmniej 3 cyfry.");
            return;
        }

        Console.WriteLine("Poszczególne cyfry liczby:");
        DisplayDigitOfNumber(number);

        Console.ReadLine();
    }

    static void DisplayDigitOfNumber(int number)
    {
        if (number > 9)
        {
            Console.WriteLine("LICZBA {0} {1}", number, number / 10);
            DisplayDigitOfNumber(number / 10);
        }

        Console.WriteLine(number % 10);
    }
}

