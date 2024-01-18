using System;

class Program
{
    static void Main()
    {
        // Get user input
        Console.Write("Enter a positive integer: ");
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            // Check if input is valid
            if (userInput <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                // Call the function to print the pattern
                PrintPattern(userInput);
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    static void PrintPattern(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
