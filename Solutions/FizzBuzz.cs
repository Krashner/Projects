/*******************************************************
Fizz Buzz
By Justin Buttrey
Program that prints 1 to 100 and replaces certain numbers with text
********************************************************/
using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            //write the result using recursion
            Console.Write(Recursion(1, 100));
            //requitres input to close
            Console.ReadKey();
        }
      
        static string Recursion(int a, int b)
        {
            string output = "";
            //break the recursion
            if (a > b)
            {
                return null;
            }
            //check to see if a is divisible by 3 and then by 5
            if (DivisibleBy(a, 3))
            {
                output += "Fizz";
            }

            if (DivisibleBy(a, 5))
            {
                output += "Buzz";
            }
            //if not divisible then dont change the number
            if (output == "")
            {
                output = a.ToString();
            }

            return output + " " + Recursion(++a, b);

        }

        //simple divisibitly checking
        static bool DivisibleBy(int a, int b)
        {
            return a % b == 0;
        }
    }
}
