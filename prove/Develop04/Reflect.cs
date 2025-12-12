using System;
using System.IO;
using System.Security.Cryptography;
public class Reflect
{

    public string GetReflectName()
    {
        return "Reflecting Activity.";
    }

    public string GetReflectDescription()
    {
        return "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }


    public void RunReflect()
    {

        // RunBreathe method of the Breathe class.


        int _timeSeconds = 30;
        string _textBreatheIn = "Breathe in...";
        string _textBreatheOut = "Now Breathe out...";

        while (_timeSeconds > 0)
        {
            Console.WriteLine();
            for (int i = 4; i >= 0; i -= 1)
            {
                Console.Write($"{_textBreatheIn} {i}");
                Thread.Sleep(500);
                if (i != 0)
                {
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); // Erase the characters
                    Thread.Sleep(500);
                }
                else
                {
                    Console.Write("\b \b"); // Erase the characters
                    Thread.Sleep(500);
                }

            }
            Console.Write("\b");
            Console.WriteLine();
            for (int j = 6; j >= 0; j -= 1)
            {
                Console.Write($"{_textBreatheOut} {j}");
                Thread.Sleep(500);
                if (j != 0)
                {
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); // Erase the characters
                    Thread.Sleep(500);
                }
                else
                {
                    Console.Write("\b \b"); // Erase the characters
                    Thread.Sleep(500);
                }
            }
            Console.WriteLine();
            _timeSeconds -= 10;

        }
        Console.WriteLine();

        return;
    }

}
    

