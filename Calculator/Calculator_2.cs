using System;
namespace Calculator
{
    public class Calculator_2
    {
        Storage storage = new Storage();
        Сalculations сalculations = new Сalculations();
        double number;
        string stringOp;

        public Calculator_2(string s)
        {
            var result = double.TryParse(s, out number);
            stringOp = s;
            if (result)
            {
                //Console.WriteLine(number);
                  var nnn = Operation1();
                Console.WriteLine(nnn);
            }

            else if (s == "sin" || s == "cos" || s == "tg" || s == "atg"
                        || s == "ln" || s == "log10" || s == "exp"
                        || s == "!" || s == "1/x" || s == "+"
                        || s == "-" || s == "*" || s == "/" || s == "=")
            {
                Operation2();
            }            
            else
            {
                Console.WriteLine("25 25 25 25 25 ");
                throw new Exception("Ошибка в calculation_2");
            }
        }
        double Operation1()
        {
            Console.WriteLine("operation1");
            if (storage.operation == null)
            {
                storage.result = number;
                Console.WriteLine(storage.result);
                Console.WriteLine(storage.operation);
                return storage.result;
            }
            else
            {
                return Operation3();
            }
        }
        void Operation2()
        {
            Console.WriteLine("operation2");
            storage.operation = stringOp; 
            Console.WriteLine(storage.result);
            Console.WriteLine(storage.operation);
        }
        double Operation3()
        {
            Console.WriteLine("operation3");
            switch (storage.operation)
            {
                case "+":
                    var b = сalculations.Sum(number);
                    Console.WriteLine(b);
                    return b;
                    
                default:
                    return 7777;
                    
            }
                
        }
    }
}
