using System;

class Program
{
    static void Main(string[] args)
    {

        // Guess the magic number program written by Chris Johnson 9/24/25

        DisplayMessage();
        string name = PromptUserName();
        //Console.WriteLine($"Your Name is: {name}.");
        int favNumber = PromptFavoriteNumber();
        //Console.WriteLine($"Your Favorite number is: {favNumber}.");
        int birthYear = PromptBirthYear();
       // Console.WriteLine($"Your Birth Year is: {birthYear}.");
        int squareNumber = SquareInteger(favNumber);
       // Console.WriteLine($"The square of your number is: {squareNumber}.");
        int yourAge = AgeInteger(birthYear);
        //Console.WriteLine($"Your age this year is: {yourAge}.");
        DisplaySummary(name, squareNumber, yourAge);

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {

            string name;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            return name;
        }

        static int PromptFavoriteNumber()
        {
            int favNumber;

            Console.Write("Please enter your favorite number:");
            string textFromUser = Console.ReadLine();
            favNumber = int.Parse(textFromUser);
            return favNumber;
        }

        static int PromptBirthYear()
        {
            int birthYear;

            Console.Write("Please enter the year you were born:");
            string textFromUser = Console.ReadLine();
            birthYear = int.Parse(textFromUser);
            return birthYear;
        }

        static int SquareInteger(int favNumber)
        {
            int squareNumber;

            squareNumber = favNumber * favNumber;
            return squareNumber;
        }

        static int AgeInteger(int birthYear)
        {
            int age;

            age = 2025 - birthYear;
            return age;
        }

        static void DisplaySummary(string name, int squareNumber, int yourAge)
        {

            Console.WriteLine($"{name}, the square of your number is {squareNumber}.");
            Console.WriteLine($"{name}, you will turn {yourAge} years old this year.");

        }

    }
}