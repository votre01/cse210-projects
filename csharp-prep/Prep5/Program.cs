using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");            
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }

        static void DisplayResult(string name, int squareNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squareNumber}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(name, squareNumber);
    }
}