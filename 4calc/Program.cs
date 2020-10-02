using System;
using System.Collections.Generic;
using Calculator;

namespace _4calc
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("1. +\t2. -\t3.*\t4. /\t5. ^\t6. =\n" +
                "7. sin\t8. cos\t9. tg\t10. atg\n" +
                    "11. ln\t12. log10\t13. exp\n" +
                    "14. !\t15. 1/x\t C");
            
            Calculator_2 calculator_2 = new Calculator_2();            
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string input = Console.ReadLine();
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
