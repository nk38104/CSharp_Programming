﻿using System;
using System.Collections.Generic;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbersToDivide = new List<double>(2);
            List<string> Formats = new List<string> { "C2", "E", "F2", "G", "N", "X" };

            try 
            {
                numbersToDivide.Add(GetUserIntInput("divident"));
                numbersToDivide.Add(GetUserIntInput("divisor"));

                Console.WriteLine("\nRESULTS:");

                if (numbersToDivide[1] != 0)
                {
                    DisplayDivisionResults(numbersToDivide, Formats);
                }
                else
                {
                    Console.WriteLine("Divisor can not be 0. Division by 0 is undefined.");
                }
            }
            catch (FormatException fex) 
            {
                Console.WriteLine(fex.Message);
            }
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        static public double GetUserIntInput(string postiion)
        {
            Console.Write($"Enter {postiion}: ");
            return double.Parse(Console.ReadLine());
        }

        static void DisplayDivisionResults(List<double> numbers, List<string> formats)
        {
            foreach (string format in formats)
            {
                PrintQuotientInFormat(numbers, format);
            }
        }

        static void PrintQuotientInFormat(List<double> numbers, string format)
        {
            var result = (format.StartsWith("X")) ? Convert.ToInt64(numbers[0]/numbers[1]).ToString($"{format}") 
                                                    : (numbers[0] / numbers[1]).ToString($"{format}");

            Console.WriteLine($"{numbers[0]} / {numbers[1]} = {result}");
        }
    }
}
