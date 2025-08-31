using System;

class Program
{
    static void Main()
    {
        // Starting message for the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Run shipping quote logic inside a dedicated method
        RunShippingQuote();
    }

    // Handles user input and quote calculation
    static void RunShippingQuote()
    {
        // Ask for weight and convert
        Console.Write("Enter the weight of your package (lbs): ");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Stop if weight is too high
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Collect dimensions from the user
        Console.Write("Enter the width of the package (inches): ");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter the height of the package (inches): ");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter the length of the package (inches): ");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Calculate combined size
        decimal dimensionSum = width + height + length;

        // Reject if too large
        if (dimensionSum > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Compute quote using provided formula
        decimal total = (width * height * length * weight) / 100;

        // Print the result formatted
        Console.WriteLine($"Your estimated total for shipping this package is: ${total:0.00}");
        Console.WriteLine("Thank you!");
    }
}
