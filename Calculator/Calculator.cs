//using System;

//namespace Calculator
//{
//    public class NewCalculator
//    {
//        Storage storage = new Storage();
//        Сalculations сalculations = new Сalculations();
//        double bbbbb;


//        public double CheckResult
//        {
//            get
//            {
//                return storage.result;
//            }
//        }
//        public string CheckOperation
//        {
//            get
//            {
//                return storage.operation;
//            }
//        }

//        public double x;
//        public string op;

//        public double Calculation()
//        {
//            if (op == "sin" || op == "cos" || op == "tg" || op == "atg"
//                        || op == "ln" || op == "log10" || op == "exp" || op == "!" || op == "1/x")
//            {
//                return CalcLog(x);
//            }
//            else
//            {
//                if (storage.operation == null)
//                {
//                    storage.result = x;
//                    storage.operation = op;
//                    return storage.result;
//                }
//                //if (storage.operation == null && storage.result == 0)
//                //{
//                //    storage.result = x;
//                //    storage.operation = op;
//                //    return storage.result;
//                //}
//                //else if (storage.operation == null)
//                //{
//                //    storage.operation = op;
//                //    return storage.result = Calc(x);
//                //}
//                else
//                {
//                    return storage.result = Calc(x);
//                }
//            }
//        }


//        public double Calc(double x)
//        {
//            switch (storage.operation)
//            {
//                case "+":
//                    //storage.result = сalculations.Sum(x);                    
//                    //storage.operation = op;
//                    //return storage.result;

//                    bbbbb = сalculations.Sum(x);
//                    return bbbbb;
//                case "-":
//                    storage.result = сalculations.Substract(x);
//                    storage.operation = op;
//                    return storage.result;
//                case "*":
//                    storage.result = сalculations.Multiply(x);
//                    storage.operation = op;
//                    return storage.result;
//                case "/":
//                    storage.result = сalculations.Divide(x);
//                    storage.operation = op;
//                    return storage.result;
//                case "^":
//                    storage.result = сalculations.Pow(x);
//                    storage.operation = op;
//                    return storage.result;
//                default:
//                    throw new Exception("Неверная команда Calc");
//            }
//        }
//        public double CalcLog(double x)
//        {
//            switch (op)
//            {
//                case "sin":
//                    storage.result = сalculations.Sin(x);
//                    return storage.result;
//                case "cos":
//                    storage.result = сalculations.Cos(x);
//                    return storage.result;

//                case "tg":
//                    storage.result = сalculations.Tg(x);
//                    return storage.result;

//                case "atg":
//                    storage.result = сalculations.Atg(x);
//                    return storage.result;

//                case "ln":
//                    storage.result = сalculations.Ln(x);
//                    return storage.result;

//                case "log10":
//                    storage.result = сalculations.Log10(x);
//                    return storage.result;

//                case "exp":
//                    storage.result = сalculations.Exp(x);
//                    return storage.result;

//                case "!":
//                    storage.result = сalculations.Factorial(x);
//                    return storage.result;

//                case "1/x":
//                    storage.result = сalculations.OneX(x);
//                    return storage.result;
//                default:
//                    throw new Exception("Ошибка в CalcLog");
//            }

//        }

//        //public double Sum(double x)
//        //{
//        //    storage.result += x;
//        //    if (op != "=")
//        //    {
//        //        storage.operation = op;
//        //        return storage.result;
//        //    }
//        //    else
//        //    {
//        //        return Equals();
//        //    }
//        //}
//        //public double Substract(double x)
//        //{
//        //    storage.result -= x;
//        //    if (op != "=")
//        //    {
//        //        storage.operation = op;
//        //        return storage.result;
//        //    }
//        //    else
//        //    {
//        //        return Equals();
//        //    }
//        //}
//        //public double Multiply(double x)
//        //{
//        //    storage.result *= x;
//        //    if (op != "=")
//        //    {
//        //        storage.operation = op;
//        //        return storage.result;
//        //    }
//        //    else
//        //    {
//        //        return Equals();
//        //    }
//        //}
//        //public double Divide(double x)
//        //{
//        //    if (x == 0)
//        //        throw new Exception("Деление на 0");
//        //    else
//        //    {
//        //        storage.result /= x;
//        //        if (op != "=")
//        //        {
//        //            storage.operation = op;
//        //            return storage.result;
//        //        }
//        //        else
//        //        {
//        //            return Equals();
//        //        }
//        //    }
//        //}
//        //public double Pow(double x)
//        //{
//        //    storage.result = Math.Pow(storage.result, x);
//        //    if (op != "=")
//        //    {
//        //        storage.operation = op;
//        //        return storage.result;
//        //    }
//        //    else
//        //    {
//        //        return Equals();
//        //    }
//        //}
//        //public double Equals()
//        //{
//        //    storage.operation = null;
//        //    return storage.result;
//        //}

//        //public double Sin(double degrees)
//        //{
//        //    double angle = Math.PI * degrees / 180;
//        //    double sinAngle = Math.Sin(angle);
//        //    return sinAngle;
//        //}
//        //public double Cos(double degrees)
//        //{
//        //    double angle = Math.PI * degrees / 180;
//        //    double cosAngle = Math.Cos(angle);
//        //    return cosAngle;
//        //}
//        //public double Tg(double degrees)
//        //{
//        //    double angle = Math.PI * degrees / 180;
//        //    double tanAngle = Math.Tan(angle);
//        //    return tanAngle;

//        //}
//        //public double Atg(double degrees)
//        //{
//        //    double angle = Math.PI * degrees / 180;
//        //    double atanAngle = Math.Atan(angle);
//        //    return atanAngle;
//        //}
//        //public double Factorial(double x)
//        //{
//        //    if (x == 0)
//        //        return 1;
//        //    else
//        //    {
//        //        double result = 1;
//        //        for (int i = 1; i <= x; i++)
//        //        {
//        //            result *= i;
//        //        }
//        //        return result;
//        //    }
//        //}

//        //public double Ln(double x)
//        //{
//        //    double n = Math.Log(x);
//        //    return n;
//        //}
//        //public double Log10(double x)
//        //{
//        //    double n = Math.Log10(x);
//        //    return n;
//        //}
//        //public double Exp(double x)
//        //{
//        //    double n = Math.Exp(x);
//        //    return n;
//        //}
//        //public double OneX(double x)
//        //{
//        //    double n = 1 / x;
//        //    return n;
//        //}
//    }
//}
