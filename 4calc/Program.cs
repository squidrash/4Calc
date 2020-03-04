using System;
using Calculator;

namespace _4calc
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////teeeeeesst
            Calculator1 calculator = new Calculator1();
            Console.WriteLine("1. +\t2. -\t3.*\t4. /\t5. ^\t6. =\n" +
                "7. sin\t8. cos\t9. tg\t10. arctg\n" +
                    "11. Ln\t12. Log10\t13. Exp\n" +
                    "14. !\t15. 1/x");
            while (true)
            {
                try
                {
                    double x = Double.Parse(Console.ReadLine());
                    string op = Console.ReadLine();

                    calculator.x = x;
                    calculator.op = op;

                    Console.WriteLine(calculator.Calculation());
                    Console.WriteLine($"Result {calculator.CheckResult}");
                    Console.WriteLine($"Operation {calculator.CheckOperation}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
    
    
}
