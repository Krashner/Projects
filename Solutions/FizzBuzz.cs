/*******************************************************
Fizz Buzz
By Justin Buttrey
Program that prints 1 to 100 and replaces certain numbers with text
********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            string output = "";
         
            //prints the numbers from 1 to 100. 
            for (int i = 0; i <= 100; i++)
            {
                output = i.ToString();

                if (i % 3 == 0 && i % 5 == 0) //For numbers which are multiples of both three and five print “FizzBuzz”.
                {
                    if (i > 0)
                    {
                        output = "FizzBuzz";
                    }
                }
                else if (i % 3 == 0)//for multiples of three print “Fizz” instead of the number
                {
                    output = "Fizz";
                }
                else if (i % 5 == 0)//for the multiples of five print “Buzz”. 
                {
                    output = "Buzz"; 
                }

                //prevents trailing comma
                if (i < 100)
                {
                    Console.Write(output + ", ");
                }
                else
                {
                    Console.Write(output);
                }
            }

            //requitres input to close
            Console.ReadKey();

        }
    }
}
