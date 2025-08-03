using System;

public class TicketPriceCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Ticket Price Calculator ---");

        while (true)
        {
            Console.Write("Enter your age or type 'exit' to quit: ");
            string? input = Console.ReadLine();

            if (input != null && input.ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(input, out int age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Age cannot be negative. Please enter a valid age.");
                }
                else
                {
                    double price = (age <= 12 || age >= 65) ? 7.00 : 10.00;
                    Console.WriteLine($"Your ticket price is: GHC{price}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine(); // For spacing
        }

        Console.WriteLine("Thank you for using the Ticket Price Calculator!");
    }
}
