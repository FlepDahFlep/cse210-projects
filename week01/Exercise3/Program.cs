using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int Number = randomGenerator.Next(1,20);
        int guess = -1;

        Console.WriteLine("Hey! Welcome to my Guess my Number!");
        Console.WriteLine("Guess the number between 1 to 20");

        while (guess != Number)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < Number)
            {
                Console.WriteLine("Go Higher!");
            }
            else if (guess > Number)
            {
                Console.WriteLine("Go Lower!");
            }
            else
            {
                Console.WriteLine("Wow! You guessed it right! Congrats!");
            }
        }
    }
}