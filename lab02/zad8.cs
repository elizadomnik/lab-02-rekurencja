using System;

class zad9
{
    static void Main()
    {
        int min = 1;
        int max = 20;

        Console.WriteLine("Pomyśl liczbę z przedziału od 1 do 20.");
        Console.WriteLine("Odpowiedz '-1' jeśli zgadywana liczba jest mniejsza,");
        Console.WriteLine("Odpowiedz '1' jeśli zgadywana liczba jest większa,");
        Console.WriteLine("Odpowiedz '0' jeśli zgadlem.");

        int guess;
        do
        {
            guess = GuessNumber(min, max);
            Console.WriteLine("Czy to liczba {0}? (odpowiedz: -1, 0, 1)", guess);
            int response = Convert.ToInt32(Console.ReadLine());

            if (response == -1)
            {
                max = guess - 1;
            }
            else if (response == 1)
            {
                min = guess + 1;
            }
            else if (response != 0)
            {
                Console.WriteLine("Niepoprawna odpowiedź. Odpowiedz tylko '-1', '0' lub '1'.");
            }
            else {
                Console.WriteLine("Udało mi się zgadnąć liczbę!");
                break;
            }
        } while (guess != 0);

    
    }

    static int GuessNumber(int min, int max)
    {
        return (min + max) / 2;
    }
}

