using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number! 1-1000");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low :)");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too High :)");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("Thats Right!!");
            }
            else Console.WriteLine("Nevermind :|");

            Console.WriteLine("Whats your favorite school subject");
            string schoolSubject = Console.ReadLine().ToLower().Replace(" ", "");
            switch (schoolSubject)
            {
                case "english":
                    Console.WriteLine("English is okay i guess");
                    break;
                case "math":
                    Console.WriteLine("Math is so hard though");
                    break;
                case "history":
                    Console.WriteLine("History is depressing");
                    break;
                case "computer":
                    Console.WriteLine("Oh yeah!! Computer is the best");
                    break;
                case "science":
                    Console.WriteLine("Science has a lot of cool experiments");
                    break;
                default:
                    Console.WriteLine("Hmm i don't know that class");
                    break;

                    Console.ReadLine();//this is just to keep console from closing right away
            }
        }
    }
}
