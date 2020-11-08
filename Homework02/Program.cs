using System;

namespace Homework02
{
    class Game
    {
        int Guess = 0;
        int Target = 5;
        string Input = "";
        string[] Words = { "piens", "maize", "siers", "avene", "ozols", "adata", "aknas", "burka" };
        Random RandomNumber = new Random();

        public void Play()
        {
            Target = RandomNumber.Next(Words.Length);

            string a = "*";
            string b = "*";
            string c = "*";
            string d = "*";

            bool bool1 = false;
            bool bool2 = false;
            bool bool3 = false;
            bool bool4 = false;

        HERE: // added goto method

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Words[Target].Substring(0, 1)); // added first letter revealed
            if (bool1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            } 
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(a);
            if (bool2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(b);
            if (bool3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(c);
            if (bool4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(d);
            Console.ResetColor();

            Console.Write(" Guess which word I am thinking of... is it: ");
            for (int i = 0; i < Words.Length; i++)
            {
                if (i == (Words.Length - 1))
                    Console.Write("or " + Words[i] + "? ");
                else
                    Console.Write(Words[i] + ", ");
            }

            Input = Console.ReadLine();

            if (Input == Words[Target])
            {
                Console.WriteLine("Congratulations! You guessed it!");
            } 
            else if (Input == "apnika") // added "apnika" thingy
            {
                Console.WriteLine("You gaved up...");
                Console.WriteLine("Better luck next time!");
            }
            else
            {
                Console.WriteLine("Not a match. Try again!");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                if (Words[Target].Substring(1, 1) == Input.Substring(1, 1)) // added letter check
                {
                    bool1 = true;
                    a = Input.Substring(1, 1);
                } 
                if (Words[Target].Substring(2, 1) == Input.Substring(2, 1))
                {
                    bool2 = true;
                    b = Input.Substring(2, 1);
                }
                if (Words[Target].Substring(3, 1) == Input.Substring(3, 1))
                {
                    bool3 = true;
                    c = Input.Substring(3, 1);
                }
                if (Words[Target].Substring(4, 1) == Input.Substring(4, 1))
                {
                    bool4 = true;
                    d = Input.Substring(4, 1);
                }

                goto HERE;
                Play(); // not used anymore
            }

            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main()
        {
            Game theGame = new Game();
            theGame.Play();
        }
    }
}
