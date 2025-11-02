using System;
using System.Collections.Generic; // Required for using List<T>

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers entered by the user
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;

        // Keep asking for numbers until the user enters 0
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // ---------------------------
        // Core Requirements
        // ---------------------------

        // Compute the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Compute the average
        double average = 0;
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }

        // Find the largest number
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // ---------------------------
        // Stretch Challenge
        // ---------------------------

        // Find the smallest positive number
        int smallestPositive = int.MaxValue;
        bool foundPositive = false;

        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
                foundPositive = true;
            }
        }

        if (foundPositive)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Sort the numbers and display them
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
