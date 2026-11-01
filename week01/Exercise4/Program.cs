using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a lis of numbers, Type 0 when finished ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        int max = numbers[0];
        foreach (int number in numbers)
        {
        if (number > max)
        {
            max = number;
        } 
        }
        Console.WriteLine($"The sum is {sum}");
        double average = (double) sum / numbers.Count;
        Console.WriteLine($"The Average is {average}");
        Console.WriteLine($"The Largest Number is {max}");

    }
}