using System;

namespace _4calc
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////teeeeeesst
            Calculator calculator = new Calculator();
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
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
    class Storage
    {
        private double Result { get; set; }
        public double result
        {
            get
            {
                return Result;
            }
            set
            {
                Result = value;
            }
        }
        private string Operation { get; set; }
        public string operation
        {
            get
            {
                return Operation;
            }
            set
            {
                Operation = value;
            }
        }
    }
    class Calculator
    {
        Storage storage = new Storage();

        public double CheckResult
        {
            get
            {
                return storage.result;
            }
        }
        public string CheckOperation
        {
            get
            {
                return storage.operation;
            }
        }

        public double x;
        public string op;

        public double Calculation()
        {
            if (op == "sin" || op == "cos" || op == "tg" || op == "atg"
                        || op == "ln" || op == "log10" || op == "exp" || op == "!" || op == "1/x")
            {
                return CalcLog(x);
            }
            else
            {
                if (storage.operation == null)
                {
                    storage.result = x;
                    storage.operation = op;
                    return storage.result;
                }
                //if (storage.operation == null && storage.result == 0)
                //{
                //    storage.result = x;
                //    storage.operation = op;
                //    return storage.result;
                //}
                //else if (storage.operation == null)
                //{
                //    storage.operation = op;
                //    return storage.result = Calc(x);
                //}
                else
                {
                    return storage.result = Calc(x);
                }
            }
        }

        public double Calc(double x)
        {
            switch (storage.operation)
            {
                case "+":
                    storage.result = Sum(x);
                    return storage.result;
                case "-":
                    storage.result = Substract(x);
                    return storage.result;
                case "*":
                    storage.result = Multiply(x);
                    return storage.result;
                case "/":
                    storage.result = Divide(x);
                    return storage.result;
                case "^":
                    storage.result = Pow(x);
                    return storage.result;
                default:
                    throw new Exception("Неверная команда Calc");
            }
        }
        public double CalcLog(double x)
        {
            switch (op)
            {
                case "sin":
                    storage.result= Sin(x);
                    return storage.result;
                case "cos":
                    storage.result = Cos(x);
                    return storage.result;

                case "tg":
                    storage.result = Tg(x);
                    return storage.result;

                case "atg":
                    storage.result = Atg(x);
                    return storage.result;

                case "ln":
                    storage.result = Ln(x);
                    return storage.result;

                case "log10":
                    storage.result = Log10(x);
                    return storage.result;

                case "exp":
                    storage.result = Exp(x);
                    return storage.result;


                case "!":
                    if (x % 1 == 0 && x >= 0)
                    {
                        storage.result = Factorial(x);
                        return storage.result;
                    }
                    else
                        throw new Exception("Число должно быть целое и больше 0");
                case "1/x":
                    storage.result = OneX(x);
                    return storage.result;
                default:
                    throw new Exception("Ошибка в CalcLog");
            }            

        }

        public double Sum(double x)
        {
            storage.result += x;
            if (op != "=")
            {
                storage.operation = op;
                return storage.result;
            }
            else
            {
                return Equals();
            }
        }
        public double Substract(double x)
        {
            storage.result -= x;
            if (op != "=")
            {
                storage.operation = op;
                return storage.result;
            }
            else
            {
                return Equals();
            }
        }
        public double Multiply(double x)
        {
            storage.result *= x;
            if (op != "=")
            {
                storage.operation = op;
                return storage.result;
            }
            else
            {
                return Equals();
            }
        }
        public double Divide(double x)
        {
            if (x == 0)
                throw new Exception("Деление на 0");
            else
            {
                storage.result /= x;
                if (op != "=")
                {
                    storage.operation = op;
                    return storage.result;
                }
                else
                {
                    return Equals();
                }
            }
        }
        public double Pow(double x)
        {
            storage.result = Math.Pow(storage.result, x);
            if (op != "=")
            {
                storage.operation = op;
                return storage.result;
            }
            else
            {
                return Equals();
            }
        }
        public double Equals()
        {
            storage.operation = null;
            return storage.result;
        }

        public double Sin(double degrees)
        {
            double angle = Math.PI * degrees / 180;
            double sinAngle = Math.Sin(angle);
            return sinAngle;
        }
        public double Cos(double degrees)
        {
            double angle = Math.PI * degrees / 180;
            double cosAngle = Math.Cos(angle);
            return cosAngle;
        }
        public double Tg(double degrees)
        {
            double angle = Math.PI * degrees / 180;
            double tanAngle = Math.Tan(angle);
            return tanAngle;

        }
        public double Atg(double degrees)
        {
            double angle = Math.PI * degrees / 180;
            double atanAngle = Math.Atan(angle);
            return atanAngle;
        }
        public double Factorial(double x)
        {
            if (x == 0)
                return 1;
            else
            {
                double result = 1;
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        public double Ln(double x)
        {
            double n = Math.Log(x);
            return n;
        }
        public double Log10(double x)
        {
            double n = Math.Log10(x);
            return n;
        }
        public double Exp(double x)
        {
            double n = Math.Exp(x);
            return n;
        }
        public double OneX(double x)
        {
            double n = 1 / x;
            return n;
        }
    }
}
