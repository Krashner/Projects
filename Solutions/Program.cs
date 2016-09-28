/*******************************************************
Find E to the Nth Digit
By Justin Buttrey
Program to find PI to a specified decimal place
********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEToTheNthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int decimalPlace = 0;  //user input is stored here
                double e = Math.E; // value for e

                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\n" + "Enter how many decimal places of e you would like to see (limit 10):" + "\n");

                //input validation
                try
                {
                    //get user input and convert it to int
                    decimalPlace = Convert.ToInt32(Console.ReadLine());
                    //if input is less than or equal to 10 allow
                    if (decimalPlace <= 10)
                        Console.WriteLine("\n" + "E to '" + decimalPlace + "' decimal places is " + FormatNumberNoRounding(e, decimalPlace) + "\n");
                    else//input too high
                        Console.WriteLine("Input too high." + "\n");
                }
                catch//bad input
                {
                    Console.WriteLine("Invalid input." + "\n");
                }

            }
        }

        //gets the number to decimal place without rounding it
        public static double FormatNumberNoRounding(double d, int decimalPlaces)
        {
            double factor = Math.Pow(10, decimalPlaces);//gets the decimal place
            double shortenedNumber = Math.Floor(d * factor) / factor;//gets rid of the numbers past decimal place
            return shortenedNumber;
        }
    }
}
