﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_sequence_While_Loop_
{
    class Program
    {
        static void Main(string[] args)
        {


            int fibonacciCount;

            Console.Write("How many Fibonacci numbers you want to calculate?: ");
            fibonacciCount = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            while (fibonacciCount < 2)
            {
                Console.Clear();
                Console.Write($"Enter a number greater than 2:");
                fibonacciCount = Convert.ToInt32(Console.ReadLine());

            }
            FibonacciCalculation(fibonacciCount);
            //double finalResult = FibonacciCalculation(fibonacciCount);
            // Console.WriteLine($"The number in Fibonacci sequence at {fibonacciCount} is {finalResult}");
            Console.ReadKey();
        }

        private static long FibonacciCalculation(int fibonacciCount)
        {
            long FirstInput = 0, SecondInput = 1;
            long nextSequenceNumber = 0;
            int i = 2;
            if (fibonacciCount >= 2)
            {

                Console.WriteLine($"The first {fibonacciCount} numbers in Fibonacci sequence are: ");
                Console.WriteLine($"Number 1 is: {FirstInput}");
                Console.WriteLine($"Number 2 is: {SecondInput}");
                while(i<fibonacciCount)
                {
                    nextSequenceNumber = FirstInput + SecondInput;
                    Console.Write($"Number {i + 1} is: {nextSequenceNumber}\n");
                    FirstInput = SecondInput;
                    SecondInput = nextSequenceNumber;
                    i++;
                }



            }

            return nextSequenceNumber;
        }
    }
}

