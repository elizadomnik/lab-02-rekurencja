using System;

class zad4
{
    static void Main()
    {
        Console.Write("Podaj kwotę początkową: ");
        double initAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj oprocentowanie: ");
        double interest = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj liczbę miesięcy: ");
        int numberOfMonths = Convert.ToInt32(Console.ReadLine());

        double monthInterest = interest / 12 / 100;
        double tax = 0.81; // Podatek belki 19% - 100% - 19% = 81

        double finalAmount = initAmount * Math.Pow(1 + monthInterest, numberOfMonths);
        double earnedAmount = finalAmount - initAmount;
        double earnedAmountAfterTax = earnedAmount * tax;

        Console.WriteLine("Zaoszczędzona kwota po  " + numberOfMonths + " miesiącach: " + earnedAmountAfterTax.ToString("F2"));
    }
}

