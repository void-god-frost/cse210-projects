using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program ");
    }
    static string PromptUserName()
    {
        Console.Write("Please Enter your name? ");
        string name = Console.ReadLine();
            return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite integer? ");
        string answer = Console.ReadLine();
        int answerNumber = int.Parse(answer);
            return answerNumber;
    }
    static int SquareNumber(int answerNumber)
    {
        int square = answerNumber * answerNumber;
            return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}