using System;

namespace SelectionStatementsExcercise_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorit subject?");
            Console.WriteLine("1: Math 2: Science 3: History 4: English 5: Art ");
            string use2 = Console.ReadLine();


            switch (use2)
            {
                case "math":
                    Console.WriteLine("Math is cool");
                    break;
                case "science":
                    Console.WriteLine("Science is cool");
                    break;
                case "history":
                    Console.WriteLine("History is cool");
                    break;
                case "english":
                    Console.WriteLine("English is cool");
                    break;
                case "art":
                    Console.WriteLine("Art is cool");
                    break;
                default:
                    Console.WriteLine("Thats not a subject choice or you spelt it wrong. (All lower case)");
                    break;
            }
        }
    }
}
