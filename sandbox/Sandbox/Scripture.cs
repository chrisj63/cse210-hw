using System;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

public class Scripture
{

       // string _nextEntry;
        string _textScripture2 = "Whatever principle of intelligence we attain unto in this life, it will rise with us in the resurrection. And if a person gains more knowledge and intelligence in this life through his diligence and obedience than another, he will have so much the advantage in the world to come. ";
        string _textReference2 = "Doctrine and Covenants 130:18-19";
        string _textScripture1 = "Whatever principle of intelligence we attain unto in this life, it will rise with us in the resurrection. ";
        string _textReference1 = "Doctrine and Covenants 130:18";
        public string _scriptureReference;

        Reference r1 = new Reference("Doctrine and Covenants", 130, 18, 19);

        Random randomGenerator = new Random();
       
       List<Word> _scriptureWords = new List<Word>();
       // List<string> _scriptureWordsVisible = new List<string>();

    public void ScriptureMenu()
    {

        //  This is the ScriptureMenu method of the Scripture class.
        //  It loops through completing different cases based on the user choice 1-5.
        //  All cases are handled in this method except the Write choice which is handled in the Entry class.
        //  An entries List variable holds all the journal entries.
        //  A file scripture.txt holds the scripture entry for long term storage. (C:\vscodeCsharp\cse210-hw\prove\Develop03\scripture.txt)
        //  A file reference.txt holds the scripture reference entry for long term storage. (C:\vscodeCsharp\cse210-hw\prove\Develop03\reference.txt)

        string textFromUser;
        //string nextEntry;
        int userChoice = 0;
       
		while (userChoice !=5)
        {
            Console.WriteLine("Welcome to the Scripture Memorization Program!");
			Console.WriteLine("Please select one of the following choices:");
			Console.WriteLine("1. Memorize one verse");
			Console.WriteLine("2. Memorize two verses");
			Console.WriteLine("3. Load one verse");
			Console.WriteLine("4. Create Word objects");
			Console.WriteLine("5. Exit Program");
            Console.WriteLine("6. Display Word objects Scripture.");
            Console.WriteLine("7. Create Word objects 2");
            Console.WriteLine("8. Get Reference");
			Console.WriteLine("What would you like to do?  ");
            textFromUser = Console.ReadLine();
                if (textFromUser == "quit")
                {
                    userChoice = 5;
                }
                else
                {
                userChoice = int.Parse(textFromUser);
                Console.WriteLine();
                }

                if (userChoice == 1)
                {
                    DisplayScripture(1);
                }
                if (userChoice == 2)
                {
                    DisplayScripture(2);
                }
                if (userChoice == 3)
                {
                    SpliceScripture(_textScripture1);
                }
                if (userChoice == 4)
                {
                    _scriptureReference = _textReference1;
                    SpliceScripture2(_textScripture1);

                    Console.WriteLine();
                //  Console.WriteLine("In the middle");
                    Console.WriteLine();
                    

                    
                    {
                    // _scriptureWords.Add($"{_line}");
                        Console.WriteLine($"{_scriptureWords}");
                    }
                }
                if (userChoice == 7)
                {
                    _scriptureReference = _textReference2;
                    SpliceScripture2(_textScripture2);

                    Console.WriteLine();
                    Console.WriteLine("In the middle");
                    Console.WriteLine();
                    

                    
                    {
                    // _scriptureWords.Add($"{_line}");
                        Console.WriteLine($"{_scriptureWords}");
                    }



                }
                if (userChoice == 5)
                {
                    
                }
                if (userChoice == 6)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine();
                    scriptureOutputMethod();
                    Console.WriteLine();
                    Console.WriteLine();
                    scriptureActiveOutputMethod();
                    Console.WriteLine();


                }
                if (userChoice == 8)
                {
                    Console.WriteLine();
                    Console.WriteLine(r1.Get());
                    Console.WriteLine();
                    Console.WriteLine();
                }
        //return;
        }
    }


            public void DisplayScripture(int localUserChoice)
            {

                Console.Clear();

                if (localUserChoice == 1)
                {
                    Console.WriteLine(_textReference1);
                    Console.WriteLine();
                    Console.WriteLine(_textScripture1);
                    Console.WriteLine();
                }

                if (localUserChoice == 2)
                {
                    Console.WriteLine(_textReference2);
                    Console.WriteLine();
                    Console.WriteLine(_textScripture2);
                    Console.WriteLine();
                }

                            
                return;
            }

            public void SpliceScripture(string localWord)
            {
                string whole = localWord;

                string[] words = whole.Split(" ");

                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }

                return;
            }

            public void SpliceScripture2(string localWord)
            {
                string whole = localWord;
                //string text2;

                string[] words = whole.Split(" ");

                foreach (string text in words)
                {
                    //Console.WriteLine(text);
                    _scriptureWords.Add(new Word(text));
                }
            }

            public void scriptureActiveOutputMethod()
            {
                
                
                int magicNumber = randomGenerator.Next(0, _scriptureWords.Count);
                
                _scriptureWords[magicNumber].Hide();

                magicNumber = randomGenerator.Next(0, _scriptureWords.Count);
                
                _scriptureWords[magicNumber].Hide();

                scriptureOutputMethod();

            }
           public void scriptureOutputMethod()
           {
           
                Console.WriteLine(_scriptureReference);
                Console.WriteLine();

                foreach (Word word in _scriptureWords)
                {
                    Console.Write(word.Display());
                    Console.Write(" ");
                }
           }

             public void scriptureReferenceSetMethod(string book, int chapter, int startVerse, int endVerse)
           {
           
                Console.WriteLine(_scriptureReference);
                Console.WriteLine();

                foreach (Word word in _scriptureWords)
                {
                    Console.Write(word.Display());
                    Console.Write(" ");
                }
           }


}

        
      /*
        { 
            case 1:

                Console.WriteLine();

                // string[] _lines = System.IO.File.ReadAllLines(_textScripture);
                string text = "Whatever principle of intelligence we attain unto in this life, it will rise with us in the resurrection. And if a person gains more knowledge and intelligence in this life through his diligence and obedience than another, he will have so much the advantage in the world to come.";
                foreach (string oneWord in text.Split(" "))
                {
                    _scriptureWords.Add(new Word(oneWord));
                }

                foreach (string _line in _lines)
                {
                    _scriptureWords.Add($"{_line}");
                    Console.WriteLine($"{_line}");
                }

                Console.WriteLine();
                Console.WriteLine("LoadFunction");
                Console.WriteLine();


                break;

            case 2:
                Console.WriteLine();

                _scriptureWordsVisible = _scriptureWords;
                
                foreach (string _line in _scriptureWordsVisible)
                {
                    Console.WriteLine($"{_line}");
                }

                Console.WriteLine();
                Console.WriteLine("GetFunction");
                Console.WriteLine();

                break;

            case 3:
                
                Console.WriteLine();

                string[] _texts = System.IO.File.ReadAllLines(_textReference);
                foreach (string _text in _texts)
                {
                    _scriptureReference = _text;
                }

                Console.WriteLine();
                Console.WriteLine("Get Scripture Reference Function : " + _scriptureReference + " .");
                Console.WriteLine();

                break;

            case 4:

                Console.WriteLine($" " + _scriptureReference + " ");

                foreach (Word word in _scriptureWords)
                {
                    Console.WriteLine(word.Display());
                }

                Console.WriteLine();
                Console.WriteLine("Display and Memorize Scripture");
                Console.WriteLine();

                break;

            case 5:

                Console.WriteLine();
                Console.WriteLine("QuitFunction");
                Console.WriteLine();

                break;

            default:

                Console.WriteLine();
                Console.WriteLine("Make a different choice, Try Again");
                Console.WriteLine();

                break;
        }
    } */

							
			

