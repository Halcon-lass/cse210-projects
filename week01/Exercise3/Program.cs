using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        
        int guess = -1;
        int numberOfGuesses = 0;
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            numberOfGuesses += 1;
            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You gussed it!");
                Console.WriteLine($"It took you {numberOfGuesses} guesses. ");
            
                Console.WriteLine("Would you like to play again, yes or no? ");
                string playAgain = Console.ReadLine();
                
                if (playAgain == "yes")
                {
                    guess = 0;
                    numberOfGuesses = 0;
                    number = randomGenerator.Next(1, 101);
                }
                else
                {
                    Console.WriteLine("Thank you for playing, goodbye!");
                }
            }
                

                


        }
    }
}