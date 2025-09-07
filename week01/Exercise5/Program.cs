using System;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string name = UserName();
        int number = UserNumber();

        int squaredNumber = SquareNumber(number);

        result(name, squaredNumber);

    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }
    static void result(string name, int square)
    {
        Console.Write($"{name}, the square of your number is: {square} ");
    }

}