using System;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Scripture Memorization Program written by Chris Johnson 12/2025.
        // Scripture class is instantiated from here.

        Scripture s1 = new Scripture();
        s1.ScriptureMenu();
    }
}