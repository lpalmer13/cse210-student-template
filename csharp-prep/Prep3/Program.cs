using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // int Magic_Number = int.Parse(Console.ReadLine());

        Random random_generator = new Random();
        int Magic_Number = random_generator.Next(1, 101);

        int guess = -1;

        while (guess != Magic_Number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (Magic_Number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (Magic_Number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}