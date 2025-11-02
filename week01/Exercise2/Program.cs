using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for grade percentage
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();

        // Convert input to integer
        int gradePercentage = int.Parse(input);

        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch challenge: Determine the sign (+ or -)
        int lastDigit = gradePercentage % 10;

        if (letter != "A" && letter != "F") // No A+ or F+ or F-
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && gradePercentage < 93)
        {
            sign = "-"; // A- between 90–92
        }

        // Display the result
        Console.WriteLine($"\nYour grade is: {letter}{sign}");

        // Check if the user passed or failed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time. Keep working hard!");
        }
    }
}
