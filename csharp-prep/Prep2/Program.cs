using System;

class Program
{
    static void Main(string[] args)
    {

        // Grading Program written by Chris Johnson 9/20/25

        string textFromUser = "10";
        string plusMinus = "";
        string letterGrade = "F";
        Boolean pass = true;


        Console.Write("Input your grade percentage score for conversion to letter grade.");
        textFromUser = Console.ReadLine();
        int numberGrade = int.Parse(textFromUser);

        if (numberGrade < 60)
        {
            letterGrade = "F";
            plusMinus = "";
        }
        if (numberGrade >= 70)
        {
            pass = true;
        }
        else
        {
            pass = false;
        }

        if (numberGrade >= 90 && numberGrade <= 100)
        {
            letterGrade = "A";
        
            if (numberGrade < 93)
            {
                plusMinus = "-";
            }
        }
        if (numberGrade >= 80 && numberGrade <= 89)
        {
            letterGrade = "B";
    
            if (numberGrade < 83)
            {
                plusMinus = "-";
            }
            else if (numberGrade >= 87)
            {
                plusMinus = "+";
            }
            else
            {
                plusMinus = "";
            }
        }
        if (numberGrade >= 70 && numberGrade <= 79)
        {

            letterGrade = "C";

            if (numberGrade < 73)
            {
                plusMinus = "-";
            }
            else if (numberGrade >= 77)
            {
                plusMinus = "+";
            }
            else
            {
                plusMinus = "";
            }
        }
        if (numberGrade >= 60 && numberGrade <= 69)
        {
            letterGrade = "D";
        
            if (numberGrade < 63)
            {
                plusMinus = "-";
            }
            else if (numberGrade >= 67)
            {
                plusMinus = "+";
            }
            else
            {
                plusMinus = "";
            }
        }
        if (numberGrade > 96 || numberGrade < 60)
        {
            plusMinus = "";
        }

        Console.WriteLine();

        if (numberGrade > 100 || numberGrade < 1)
        {
            Console.WriteLine("Your score is not in range! Run Program again");
        }

        else if (pass == true)
        {
            Console.WriteLine("Congratulations!, You passed with a grade of " + letterGrade + plusMinus + ".");
        }
        else
        {
            Console.WriteLine($"Unfortunately, You did not pass with your grade of {letterGrade}{plusMinus}. Try again next semester!");
        }	

    }
}