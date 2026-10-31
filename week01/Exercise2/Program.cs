using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage as a number? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }

        else if (number >= 80)
        {
            letter = "B";
        }

        else if (number >= 70)
        {
            letter = "C";

        }

        else if (number >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        if (number >= 70)
        {
            Console.WriteLine($"Your Grade is {letter}");
            Console.WriteLine("Congratulations! You passed.");
        }
        else if (number < 60)
        {
            Console.WriteLine($"Your Grade is {letter}");
            Console.WriteLine("DO BETTER NEXT TIME! You failed");
        }

    }
}