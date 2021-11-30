using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace FortuneTeller
{
    internal class Program
    {
        private static string ReadSpecificLine(string filePath, int lineNumber)
        {
            string content = null;
            try
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                    for (int i = 1; i < lineNumber; i++)
                    {
                        file.ReadLine();

                        if (file.EndOfStream)
                        {
                            Console.WriteLine($"End of file.  The file only contains {i} lines.");
                            break;
                        }
                    }
                    content = file.ReadLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("There was an error reading the file: ");
                Console.WriteLine(e.Message);
            }

            return content;
        }

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            string fortuneFiles = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\fortune.txt");
            bool playAgain = true;
            
            
           

            Console.WriteLine("*************************");
            Console.WriteLine("** Fortune Teller Game **");
            Console.WriteLine("*************************");

            while (playAgain)
            {
                Console.WriteLine("\nHello there, I am an interactive Fortune teller game\nI am designed to help predict your future based on answers you give me");
                Console.Write("\n\nTo begin, please tell me your name: ");
                string playerName = "";
                bool validName = false;

                while (!validName)
                {
                    try
                    {
                        playerName = Console.ReadLine();
                        bool isDigitPresent = playerName.Any(c => char.IsDigit(c));

                        if (string.IsNullOrEmpty(playerName))
                        {
                            Console.Write($"\nThat wasn't quite right, Your name can't be empty\n\nPlease try again: ");
                        }
                        else if (isDigitPresent)
                        {
                            Console.Write($"\nThat wasn't quite right, Your name can't have numbers in it\n\nPlease try again: ");
                        }
                        else
                        {
                            validName = true;
                        }
                    }
                    catch (System.Exception ex1)
                    {
                        Console.WriteLine("\n\nThat wasn't quite right and caused an error.\n\nThe error was: " + ex1.Message);
                    }
                }//ENDvalidNameWhile

                Console.Write($"\n\nOk {playerName}, let's begin. \n\n\nTell me your favorite number between 10-17: ");
                int faveNum = 0;
                bool faveNumEntered = false;

                while (!faveNumEntered)
                {
                    try
                    {
                        faveNum = Int32.Parse(Console.ReadLine());
                        faveNumEntered = true;
                    }
                    catch (System.Exception ex2)
                    {
                        Console.WriteLine("\n\nThat wasn't quite right and caused an error.\n\nThe error was: " + ex2.Message);
                        Console.Write("\n\nPlease tell me your favorite number between 10-17: ");
                    }
                }//End faveNumEntered while

                string faveNumEvenOdd = "";

                switch (faveNum)
                {
                    case 10:
                        Console.WriteLine($"You selected {faveNum}, lets count it out");
                        for (int i = 1; i <= faveNum; i++)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(300);
                        }
                        faveNumEvenOdd = "even";
                        break;

                    case 11:
                        Console.WriteLine($"You selected {faveNum}, lets count it out");
                        for (int i = 1; i <= faveNum; i++)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(300);
                        }
                        faveNumEvenOdd = "odd";
                        break;

                    case 12:
                        Console.WriteLine($"You selected {faveNum}, lets count it out");
                        for (int i = 1; i <= faveNum; i++)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(300);
                        }
                        faveNumEvenOdd = "even";
                        break;

                    case 13:
                        Console.WriteLine($"You selected {faveNum}, lets count it out");
                        for (int i = 1; i <= faveNum; i++)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(300);
                        }
                        faveNumEvenOdd = "odd";
                        break;

                    case 14:
                        Console.WriteLine($"You selected {faveNum}, lets count it out");
                        for (int i = 1; i <= faveNum; i++)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(300);
                        }
                        faveNumEvenOdd = "even";
                        break;

                    case 15:
                        Console.WriteLine($"You selected {faveNum}, lets count it out");
                        for (int i = 1; i <= faveNum; i++)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(300);
                        }
                        faveNumEvenOdd = "odd";
                        break;

                    case 16:
                        Console.WriteLine($"You selected {faveNum}, lets count it out");
                        for (int i = 1; i <= faveNum; i++)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(300);
                        }
                        faveNumEvenOdd = "even";
                        break;

                    case 17:
                        Console.WriteLine($"You selected {faveNum}, lets count it out");
                        for (int i = 1; i <= faveNum; i++)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(300);
                        }
                        faveNumEvenOdd = "odd";
                        break;

                    default:
                        Console.WriteLine("That doesn't seem quite right, please try again");
                        break;
                }

                string faveColor;
                bool validColor = false;
                int fortuneNumber = 9;
                var lineNumber = fortuneNumber;
                

                while (!validColor)
                {
                    if (faveNumEvenOdd == "even")
                    {
                        Console.Write("\nWhat is your favorite color out of: Blue, Gold, Cyan or Red? ");
                        faveColor = Console.ReadLine().ToLower();

                        switch (faveColor)
                        {
                            case "blue":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                validColor = true;
                                Console.WriteLine($"\nYou have picked the color {faveColor}");
                                fortuneNumber = 1;
                                break;

                            case "gold":
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                validColor = true;
                                Console.WriteLine($"\nYou have picked the color {faveColor}");
                                fortuneNumber = 2;
                                break;

                            case "cyan":
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                validColor = true;
                                Console.WriteLine($"\nYou have picked the color {faveColor}");
                                fortuneNumber = 3;
                                break;

                            case "red":
                                Console.ForegroundColor = ConsoleColor.Red;
                                validColor = true;
                                Console.WriteLine($"\nYou have picked the color {faveColor}");
                                fortuneNumber = 4;
                                break;

                            default:
                                Console.WriteLine("\nThat doesn't seem quite right, please try again");
                                break;
                        }
                    }
                    else
                    if (faveNumEvenOdd == "odd")
                    {
                        Console.Write("\nWhat is your favorite color out of: Magenta, Green, Gray or Yellow? ");
                        faveColor = Console.ReadLine().ToLower();

                        switch (faveColor)
                        {
                            case "magenta":

                                Console.ForegroundColor = ConsoleColor.Magenta;
                                validColor = true;
                                Console.WriteLine($"\nYou have picked the color {faveColor}");
                                fortuneNumber = 5;
                                break;

                            case "green":

                                Console.ForegroundColor = ConsoleColor.Green;
                                validColor = true;
                                Console.WriteLine($"\nYou have picked the color {faveColor}");
                                fortuneNumber = 6;
                                break;

                            case "gray":

                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                validColor = true;
                                Console.WriteLine($"\nYou have picked the color {faveColor}");
                                fortuneNumber = 7;
                                break;

                            case "yellow":

                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                validColor = true;
                                Console.WriteLine($"\nYou have picked the color {faveColor}");
                                fortuneNumber = 8;
                                break;

                            default:
                                Console.WriteLine("\nThat doesn't seem quite right, please try again");
                                break;
                        }
                    }
                }//ENDFaveColorWhile

                Console.WriteLine("\nYour fortune is: ");
                Console.WriteLine("\"" + ReadSpecificLine(fortuneFiles, fortuneNumber) + "\"");

                Console.Write("\n\nWould you like to play again? Type Yes or No: ");
                bool validExit = false;
                while (!validExit)
                {
                    string playAgainInput = Console.ReadLine().ToLower(); 

                    if (playAgainInput == "yes")
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        validExit = true;
                    }
                    else if (playAgainInput == "no")
                    {
                        playAgain = false;
                        validExit = true;
                    }
                    else
                    {
                        Console.Write("\nPlease only type Yes or No: ");
                        validExit = false;
                    }
                }
            }//End PlayAgainWhile

            Console.Write($"\n\nThanks for playing");
            Console.ReadLine();
            Environment.Exit(0);
        }//ENDMAIN
    }//ENDCLASS
}//ENDNAMESPACE