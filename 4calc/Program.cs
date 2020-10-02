using System;
using System.Collections.Generic;
using Calculator;

namespace _4calc
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("+\t-\t*\t/\t^\t=\n" +
                "sin\tcos\ttg\tatg\n" +
                    "ln\tlog10\texp\n" +
                    "!\t1/x\t C\n" +
                    "Ms\tMr\tMc\tM+\tM-");
            
            Calculator_2 calculator_2 = new Calculator_2();            
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string input = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.White;

                try
                {
                    //Calculator_2 calculator_2 = new Calculator_2(input);
                    
                    var result = calculator_2.Calculator(input);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
    
    
}
