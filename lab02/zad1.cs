// zadanie 1 - potęgowanie

using System;

public class zad1
{
    static void Main()
    {
        Console.Write("Podaj potege: ");
        int baseValue = int.Parse(Console.ReadLine());

        Console.Write("Podaj wykladnik: ");
        int expoValue = int.Parse(Console.ReadLine());

        int result = ToPower(baseValue, expoValue);

        Console.WriteLine("Wynik: " + result);

    }

    static int ToPower(int baseValue, int expoValue)
    {
        int result = 1;

        for (int i = 0; i < expoValue; i++)
        {
            result *= baseValue;
        }

        return result;
    }
}