using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string user_Name = Prompt_User_Name();
        int user_Number = Prompt_User_Number();

        int squared_Number = Square_Number(user_Number);

        Display_Result(user_Name, squared_Number);
    }

    static void DisplayWelcomeMessage()
    {
       Console.WriteLine("Welcome to the program!");
    }

    static string Prompt_User_Name()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int Prompt_User_Number()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int Square_Number(int number)
    {
        int square = number * number;
        return square;
    }

    static void Display_Result(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}