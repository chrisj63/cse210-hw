using System;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Scripture Memorization Program written by Chris Johnson 11/2025
        // Set scripture is held in the scripture.txt file. ((C:\vscodeCsharp\cse210-hw\prove\Develop03\scripture.txt))
        // Set scripture reference is held in the reference.txt file. ((C:\vscodeCsharp\cse210-hw\prove\Develop03\reference.txt))


        Scripture s1 = new Scripture();
        s1.ScriptureMenu();
    }
     
}