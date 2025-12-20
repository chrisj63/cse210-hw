using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Mindfulness Program written by Chris Johnson 12/2025
        // Mindfulness class is instantiated from here. The MindfulnessMenu() method is called from here.

        Mindfulness m1 = new Mindfulness();
        m1.MindfulnessMenu();
    }
}

