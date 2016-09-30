/*******************************************************
Fibonacci Sequence
By Justin Buttrey
Program to show the Fibonacci Sequence to a given end point. Displays both iterative and recursive methods
********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class FibonacciSequence
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int endPoint = 0;//user input is stored here

                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\n" + "Enter end point for Fubonacci sequence." + "\n");

                //input validation
                try
                {
                    Console.Write("Input: ");

                    //get user input and convert it to int
                    endPoint = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\n" + "Iterative method: ");

                    //write the iterative method
                    Console.Write(FibonacciIterative(endPoint));

                    Console.Write("\n" + "\n" + "Recursive method: ");

                    //write the recursive method
                    for (int i = 0; i <= endPoint; i++)
                    {
                        Console.Write(FibonacciRecursive(i) + "  ");
                    }

                }
                catch
                {
                    //error, invalid input
                    Console.Write("\n" + "Invalid input.");
                }

                //for text formating
                Console.WriteLine("\n");
            }
        }

        //iterative method
        static string FibonacciIterative(int n)
        {
            if (n >= 1)
            {
                int num = 0, //first value
                    num2 = 1; //second value

                string output = num + "  " + num2;

                for (int g = 1; g < n; g++)
                {
                    //current number equals the last two added together
                    int fib = num + num2;

                    //update previous numbers after adding
                    num = num2;
                    num2 = fib;

                    //add to string
                    output = output + "  " + fib;
                }
                //return string
                return output;
            }
            else
            {
                return "0";
            }

        }

        //recursive method
        static int FibonacciRecursive(int n)
        {
            if (n > 1)
            {
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }
            else
            {
                return n;
            }
        }

    }
}
