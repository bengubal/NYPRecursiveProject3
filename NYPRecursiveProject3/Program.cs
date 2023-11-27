using System;

class Program
{
    //recursive function that separating the digits of a number
    //and finding the sum of their values
    static int SumOfDigits(int number)
    {
        if (number < 10)
        {
            return number;
        }
        else
        {
            return number % 10 + SumOfDigits(number / 10);
        }
    }
    //main part of code
    static void Main()
    {
        Console.Write("Enter a number (between 10 and 99,999): ");
        int number = int.Parse(Console.ReadLine());
        int result = SumOfDigits(number);
        Console.WriteLine($"Sum of digits for {number}: {result}");
    }
}
