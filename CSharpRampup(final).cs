using System;

class Program
{
    static void Main()
    {
        ConvertWeight();
        ConvertDistance();
        ConvertTemperature();
        CalculateAverageAge();
        NarrateEpicSevenStory();
    }

    static void ConvertWeight()
    {
        Console.Write("Enter weight in pounds (lbs): ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double kilograms = pounds * 0.453592;
        Console.WriteLine($"Weight: {pounds} lbs, Converted to kilograms: {kilograms} kg");
    }

    static void ConvertDistance()
    {
        Console.Write("Enter distance in miles (mi): ");
        double miles = Convert.ToDouble(Console.ReadLine());
        double kilometers = miles * 1.60934;
        Console.WriteLine($"Distance: {miles} mi, Converted to kilometers: {kilometers} km");
    }

    static void ConvertTemperature()
    {
        Console.Write("Enter temperature in Fahrenheit (°F): ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5/9;
        Console.WriteLine($"Temperature: {fahrenheit} °F, Converted to Celsius: {celsius} °C");
    }

    static void CalculateAverageAge()
    {
        int totalAges = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter age of student {i}: ");
            int age = Convert.ToInt32(Console.ReadLine());
            totalAges += age;
        }
        double averageAge = (double)totalAges / 10;
        Console.WriteLine($"Ages of students: (list of ages), Average Age: {averageAge}");
    }

    static void NarrateEpicSevenStory()
    {
        string protagonist = "Ras";
        string companion = "Luna";
        string antagonist = "Abyss Order";
        string artifact = "Ark of the Covenant";
        string continent = "Ritania";
        string secondaryAntagonist = "Dark Sorceress Seraphina";
        string hiddenArtifact = "Chrono Crystal";
        string secretLocation = "Eclipsed Valley";
        
        // New elements
        string mentor = "Master Kael";
        string prophecy = "The Prophecy of the Eclipse";
        string ancientRace = "Celestial Elders";

        string epicSevenStory = $@"
In the mystical land of Orbis, a young hero named {protagonist} emerged to protect the world from the dark forces known as the {antagonist}.
Guided by his loyal companion {companion}, a skilled warrior with a magical sword, they journeyed to save the continent of {continent} from eternal darkness.

The {antagonist}, led by the sinister {secondaryAntagonist}, sought to unleash dark magic upon the land, aiming to overshadow the light of hope.
They coveted the ancient artifact, the {artifact}, but little did they know about the existence of another powerful relic, the {hiddenArtifact}, hidden in the mysterious {secretLocation}.

{protagonist}, mentored by the wise {mentor} and driven by {prophecy}, discovered that the fate of Orbis was intertwined with an ancient race known as the {ancientRace}.
As he delved into the depths of the treacherous dungeons and faced formidable foes, the celestial guidance of the {ancientRace} infused him with newfound powers.

The final confrontation unfolded in the heart of {secretLocation}, where the clash between the forces of light and darkness reached its climax.
With bravery, strategy, and the combined power of the {artifact}, {hiddenArtifact}, and the blessings of the {ancientRace}, {protagonist} triumphed over the dark forces, restoring peace to Orbis.

Little did he know, the journey had only just begun. New mysteries awaited in unexplored realms, and the legacy of {protagonist} and {companion} continued to unfold.";

        Console.WriteLine(epicSevenStory);
    }
}
//part 2

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");

        // Read user input as a string
        string userInput = Console.ReadLine();

        // Try to parse the input as an integer
        if (int.TryParse(userInput, out int n) && n > 0)
        {
            // Input is a positive integer
            PrintNumberPattern(n);
        }
        else
        {
            // Invalid input
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    static void PrintNumberPattern(int n)
    {
        // Loop through each row
        for (int i = 1; i <= n; i++)
        {
            // Loop to print numbers in each row
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            // Move to the next line after printing each row
            Console.WriteLine();
        }
    }
}
//part 2.1

using System;

class Program
{
    static void Main()
    {
        // Get user input
        Console.Write("Enter a positive integer: ");
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            // Call the function to calculate and print the sum
            string result = CalculateSum(userInput);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    static string CalculateSum(int n)
    {
        // Check if input is valid
        if (n <= 0)
        {
            return "Invalid input";
        }

        // Calculate the sum using the formula: 1 + 2 + 3 + ... + n
        int totalSum = 0;
        for (int i = 1; i <= n; i++)
        {
            totalSum += i;
        }

        // Return the result
        return $"input: {n}\nformula: {string.Join("+", Enumerable.Range(1, n))}\noutput: {totalSum}";
    }
}
//part 2.2

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

//code wont work if you run it since too many static void thingy on each doe which will def not let it run and will just go error so run it separately 