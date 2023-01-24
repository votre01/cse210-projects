using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Trevor Ngwenya", "Abstraction");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Felicity Moyo", "Fractions", "Section 7.3", "Problems 9-12");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Talent Ndlovu", "Ancient Music", "Origins of the Keyboard");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}