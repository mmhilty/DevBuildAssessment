using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Quiz1_1_Bond_James_Hilty
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first and last name?");
            string userInputString = Console.ReadLine();
            List<string> nameList = new List<string>(Regex.Split(userInputString, @"[ ]"));
            Console.WriteLine(nameList[1] + " " + nameList[0]);


        }
    }
}
