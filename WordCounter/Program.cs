using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string normalString;
            string[] words;

            while (true)
            {
                Console.Clear();
                Console.Write("Enter a string to have its words counted: ");
                normalString = Regex.Replace(Console.ReadLine().ToLower(), @"\s+", " ");
                Console.WriteLine();
                words = normalString.Split(' ');
                Console.WriteLine("This string has " + words.Count() + " words in it!");
                Console.Write("\nWould you like to try again? Enter Y or N: ");
                if (Regex.Replace(Console.ReadLine().ToLower(), @"\s+", " ") == "n")
                    break;
            }

        }
    }
}
