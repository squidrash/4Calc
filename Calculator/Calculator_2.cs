using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class Calculator_2
    {
        Storage storage = new Storage();
        Calculations calculations = new Calculations();
        double number;
        string tempOp;
        bool dicExist = false;
        
        List<string> allOperations = new List<string>
        { "sin", "cos", "tg", "atg", "ln", "log10", "exp",
            "!", "1/x", "+", "-", "*","/", "=","^"
        };
        Dictionary<string, Func<double, double, double>> calc_2param = new Dictionary<string, Func<double, double, double>>();
        Dictionary<string, Func<double, double>> calc_1param = new Dictionary<string, Func<double, double>>();

        void SetDictionary_2Param()
        {
            calc_2param.Add("+", calculations.Sum);
            calc_2param.Add("-", calculations.Substract);
            calc_2param.Add("*", calculations.Multiply);
            calc_2param.Add("/", calculations.Divide);
            calc_2param.Add("^", calculations.Pow);
        }
        void SetDictionary_1Param()
        {
            calc_1param.Add("sin", calculations.Sin);
            calc_1param.Add("cos", calculations.Cos);
            calc_1param.Add("tg", calculations.Tg);
            calc_1param.Add("atg", calculations.Atg);
            calc_1param.Add("ln", calculations.Ln);
            calc_1param.Add("log10", calculations.Log10);
            calc_1param.Add("exp", calculations.Exp);
            calc_1param.Add("!", calculations.Factorial);
            calc_1param.Add("1/x", calculations.OneX);
        }
        

        public double Calculator(string numberOrOperation)
        {
            if(dicExist == false)
            {
                SetDictionary_1Param();
                SetDictionary_2Param();
                dicExist = true;
            }

            tempOp = numberOrOperation;
            var TryParseString = double.TryParse(numberOrOperation, out number);
            double finalResult = 0;
            if (allOperations.Contains(numberOrOperation))
            {
                finalResult = ActionsWithOperator();
                //Console.WriteLine($"Блок if с операторами {n}");
            }
            else if (TryParseString)
            {
                finalResult = ActionsWithNumbers();
                //Console.WriteLine($" Блок If с числами{nnn}");
            }
            else
            {
                throw new Exception("Ошибка в calculation_2");
            }
            return finalResult;
        }
        double ActionsWithNumbers()
        {
            //Console.WriteLine("ActionsWithNumbers");
            if (storage.operation == null)
            {
                storage.result = number;
                //Console.WriteLine($"Operation_1 storage.result {storage.result}");
                //Console.WriteLine($"Operation_1 storage.operation{ storage.operation}");
                return storage.result;
            }
            else
            {
                return GettingValue();
            }
        }
        double GettingValue()
        {
            //Console.WriteLine("GettingValue");            
            var result = calc_2param[storage.operation];
            //Console.WriteLine("делаю с помощью словаря с 2 параметрами");
            //Console.WriteLine(result(storage.result, number));
            return storage.result = result(storage.result, number);
        }
        double ActionsWithOperator()
        {
            //Console.WriteLine("ActionsWithOperator");
            storage.operation = tempOp;
            if (tempOp == "+" || tempOp == "-" || tempOp == "*" || tempOp == "/" || tempOp == "^")
            {
                //Console.WriteLine($"Operation_2 storage.result {storage.result}");
                //Console.WriteLine($"Operation_2 storage.operation {storage.operation}");
                return storage.result;
            }
            else if (tempOp == "=")
            {
                return Equals();
            }
            else
            {
                return TrigonometricFunctions();
            }
        }
        double Equals()// как правильно сделать это метод? как его реализовать в классе Calculations?
        {
            storage.operation = calculations.Equals(storage.operation);
            //Console.WriteLine($"Equals storage.operation {storage.operation}");
            return storage.result;
        }
        double TrigonometricFunctions()
        {
            //Console.WriteLine("TrigonometricFunctions");
            var result = calc_1param[storage.operation];
            //Console.WriteLine("делаю с помощью словаря с 1 параметром");
            //Console.WriteLine(result(storage.result));
            storage.operation = null;
            return storage.result = result(storage.result);
        }
    }
}
