using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Quiz1_3_IdLikeToBuyAVowel_Hilty
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("I just learned what a vowel is! Give me some words so I can count the vowels in it!");
            string userString = Console.ReadLine();

            int vowelCount = 0;

            List<string> stringCharList = new List<string>(Regex.Split(userString,""));

            //char[] stringCharArray = userString.ToCharArray(); NVM

            foreach (string character in stringCharList)
            {
                if (Regex.IsMatch(character, @"^[AEIOUaeiou]"))
                {
                    vowelCount = vowelCount + 1;
                }

            }

            if (vowelCount > 0)
            {
                Console.WriteLine($"There are {vowelCount} vowels in your phrase! Awesome!");
            }

            else if (vowelCount == 0)
            {
                Console.WriteLine($"There aren't any vowels in your phrase. Bummer.");
            }

        }
    }
}
