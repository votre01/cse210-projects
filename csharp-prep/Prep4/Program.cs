using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)        
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        int max = numbers[0];
        foreach(int value in numbers)
        {
            // Get sum
            sum += value;

            // Get max
            if (value > max)
            {
                max = value;
            }
        }

        double average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        numbers.Sort();
        Console.WriteLine($"The sorted list is: ");
        foreach(int value in numbers)
        {
            Console.WriteLine(value);
        }

    }
}