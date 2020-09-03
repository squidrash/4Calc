using System;
namespace Calculator
{
    public class Calculator_2
    {
        Storage storage = new Storage();
        Сalculations сalculations = new Сalculations();
        double number;
        string stringOp;
        //double result;
        public string s;


        public void Calculator()
        {
            
            var variable = double.TryParse(s, out number);
            stringOp = s;
            //result = storage.result;
            

            if(s == "sin" || s == "cos" || s == "tg" || s == "atg"
                        || s == "ln" || s == "log10" || s == "exp"
                        || s == "!" || s == "1/x" || s == "+"
                        || s == "-" || s == "*" || s == "/" || s == "=")
            {
            Operation2();
            }
            else if (variable)
            {
                //Console.WriteLine(number);
                var nnn = Operation1();
                Console.WriteLine($" первый блок if{nnn}");
            }
            else
            {
                Console.WriteLine("Ошибка в calculation_2");
                throw new Exception();
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
                    storage.result = сalculations.Sum(storage.result, number);
                    Console.WriteLine(storage.result);
                    return storage.result;
                //case "+":
                //    result = сalculations.Sum(number);
                //    Console.WriteLine(result);
                //    return result;

                default:
                    return 7777;
                    
            }
                
        }
    }
}
