using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1_2_Math_Hilty
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input number for multiplication table");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int multNum = 1;

            Console.WriteLine($"The Multiplication Table of {userNum}:");
            while (multNum <= 12)
            {
                Console.WriteLine(userNum * multNum);
                multNum = multNum + 1;
            }


        }
    }
}
