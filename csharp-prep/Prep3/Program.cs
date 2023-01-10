using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int counter = 5;
        int guess = -1;
        
        while (guess != magicNumber && counter > 0)
        {
            counter--;

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }                     
        }

        if (guess == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        else
        {
            Console.WriteLine($"Your lost! The magic number is {magicNumber}");
        }
    }
}