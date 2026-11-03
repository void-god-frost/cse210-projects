using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        int guessedNumber = -1;
        while (guessedNumber != number)
        {
        Console.Write("Guess the magic number? ");
        string guess = Console.ReadLine();
        guessedNumber = int.Parse(guess);
        if (guessedNumber > number)
        {
            Console.WriteLine("Lower");
        }
        else if (guessedNumber < number)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("YOU GUESSED THE CORRECT NUMBER!");
        }
        }
 
    }
}