using System;

class Program
{
    static void Main(string[] args)
    {

        // Guess the magic number program written by Chris Johnson 9/24/25

        string playAgain = "yes";
        do
        {
            Console.WriteLine("A magic whole number between 1 and 100 has been selected?");

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            string continueGame = "yes";
            int numGuesses = 0;

            do
            {
                Console.Write("What is your guess?");
                string textFromUser = Console.ReadLine();
                int yourGuess = int.Parse(textFromUser);
                numGuesses = numGuesses + 1;

                if (yourGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (yourGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    continueGame = "no";
                }
            } while (continueGame == "yes");

        Console.WriteLine($"You made {numGuesses} guesses to get it correct.");
        Console.WriteLine();
        Console.Write("Would you like to play again? Type yes or no.");
        playAgain = Console.ReadLine();

        } while (playAgain == "yes");  

    }
}