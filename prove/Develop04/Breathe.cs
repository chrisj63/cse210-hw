using System;
using System.IO;
using System.Security.Cryptography;
public class Breathe
{
    private string _BreatheName = "Breathing Activity.";
    private string _BreatheDescription = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public string GetBreatheName()
    {
        return _BreatheName;
    }
    public string GetBreatheDescription()
    {
        return _BreatheDescription;
    }

    public void RunBreathe(int breatheTime)
    {
        // RunBreathe method of the Breathe class.
        int timeSeconds = breatheTime;
        string textBreatheIn = "Breathe in...";
        string textBreatheOut = "Now Breathe out...";

        while (timeSeconds > 0)
        {
            Console.WriteLine();
            for (int i = 4; i >= 0; i -= 1)
            {
                Console.Write($"{textBreatheIn} {i}");
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
            for (int j = 4; j >= 0; j -= 1)
            {
                Console.Write($"{textBreatheOut} {j}");
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
            timeSeconds -= 10;
        }
        Console.WriteLine();
        return;
    }
}
    

