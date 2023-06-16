using System;

public class zad9
{
    public static void Main(string[] args)
    {
        int number = 123;
        int reversedNumber = ReverseNumber(number);

        Console.WriteLine("Reversed Number: " + reversedNumber);
    }

    public static int ReverseNumber(int number)
    {
        if (number < 10)
            return number;

        int lastDigit = number % 10;
        int remainingDigits = number / 10;

        int reversedNumber = ReverseNumber(remainingDigits);

        int numberOfDigits = GetNumberOfDigits(remainingDigits);
        int multiplier = (int)Math.Pow(10, numberOfDigits);

        return (lastDigit * multiplier) + reversedNumber;
    }

    private static int GetNumberOfDigits(int number)
    {
        if (number < 10)
            return 1;

        return 1 + GetNumberOfDigits(number / 10);
    }
}
