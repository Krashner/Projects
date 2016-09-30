/*******************************************************
Collatz Conjecture
By Justin Buttrey
Program to find the number of steps to 1 using the Collatz Conjecture
********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class CollatzConjecture
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int userInput = 0;//user input is stored here

                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\n" + "Enter a starting number." + "\n");

                //input validation
                try
                {
                    Console.Write("Input: ");
                    //get user input and convert it to int
                    userInput = Convert.ToInt32(Console.ReadLine());

                    Console.Write( "\n" + userInput + ", ");

                    while (userInput > 1)
                    {
                        //this is the math, if even the number is divided by 2, 
                        //if odd the number is multiplied by 3 and added to one
                        if (userInput % 2 == 0)
                        {
                            userInput /= 2;
                        }
                        else
                        {
                            userInput = userInput * 3 + 1;
                        }

                        //this is just so there isnt a trailing ", " after the final number
                        if (userInput > 1)
                        {
                            Console.Write(userInput + ", ");
                        }
                        else
                        {
                            Console.Write(userInput + "\n" + "\n");
                        }
                    }

                }
                catch
                {
                    Console.Write("\n" + "Invalid input");
                }
            }
        }
    }
}
