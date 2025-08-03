using System;

public class TriangleTypeIdentifier
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Triangle Type Identifier ---");

        while (true)
        {
            Console.Write("Enter side 1 (or type 'exit' to quit): ");
            string? input1 = Console.ReadLine();
            if (input1 != null && input1.ToLower() == "exit") break;

            Console.Write("Enter side 2: ");
            string? input2 = Console.ReadLine();

            Console.Write("Enter side 3: ");
            string? input3 = Console.ReadLine();

            if (double.TryParse(input1, out double side1) &&
                double.TryParse(input2, out double side2) &&
                double.TryParse(input3, out double side3))
            {
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    Console.WriteLine("Sides must be positive numbers.");
                }
                else if (!IsValidTriangle(side1, side2, side3))
                {
                    Console.WriteLine("The sides do not form a valid triangle.");
                }
                else if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for all sides.");
            }

            Console.WriteLine(); // blank line for spacing
        }

        Console.WriteLine("Thank you for using the Triangle Type Identifier!");
    }

    // Triangle validity check using the triangle inequality theorem
    private static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}
