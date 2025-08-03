using System;

public class GradeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Grade Calculator ---");

        while (true)
        {
            Console.Write("Enter the numerical grade (0-100) or type 'exit' to quit: ");
            string? input = Console.ReadLine();

            if (input != null && input.ToLower() == "exit")
            {
                break;
            }

            if (double.TryParse(input, out double grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    string letterGrade;

                    if (grade >= 90) letterGrade = "A";
                    else if (grade >= 80) letterGrade = "B";
                    else if (grade >= 70) letterGrade = "C";
                    else if (grade >= 60) letterGrade = "D";
                    else letterGrade = "F";

                    Console.WriteLine($"The letter grade is: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the Grade Calculator!");
    }
}
