using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        string letter = "";

        if (int.Parse(gradePercentage) >= 90)
        {
            letter = "A";
        }
        else if (int.Parse(gradePercentage) >= 80)
        {
            letter = "B";
        }
        else if (int.Parse(gradePercentage) >= 70)
        {
            letter = "C";
        }
        else if (int.Parse(gradePercentage) >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade percentage is {gradePercentage} - Grade: {letter}");

        if (int.Parse(gradePercentage) >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass but don't give up. Give it another try.");
        }
    }
}