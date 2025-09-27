using System;

class Program
{
    static void Main(string[] args)
    {
        // Series of Numbers by Chris Johnson 9/26/25


        int numberFromUser = 1;
        double numberTotal = 0;
        double numberAverage = 0;
        decimal numAveFormatted;
        int numberMaximum = 0;
        int numberPositiveMinimum = 100;
        int numberCount = 1;
        List<int> numbers;
        numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (numberFromUser != 0)
        {
            Console.Write("Enter number:");
            string textFromUser = Console.ReadLine();
            numberFromUser = int.Parse(textFromUser);
            numbers.Add(numberFromUser);
            numberCount = numberCount + 1;
            numberTotal = numberTotal + numberFromUser;

            if (numberMaximum < numberFromUser)
            {
                numberMaximum = numberFromUser;
            }
            if (numberFromUser > 0)
            {
                if (numberPositiveMinimum > numberFromUser)
                {
                    numberPositiveMinimum = numberFromUser;
                }

            }
            
            numbers.Remove(0);

        }
        numberAverage = (numberTotal / (numberCount - 2));
        decimal numAveTemp = (decimal)numberAverage;
        numAveFormatted = Decimal.Round(numAveTemp, 4);
        Console.WriteLine($"The sum is: {numberTotal}");
        Console.WriteLine($"The average is: {numAveFormatted}");
        Console.WriteLine($"The largest number is: {numberMaximum}");
        Console.WriteLine($"The smallest positive number is: {numberPositiveMinimum}");


        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

    }
}