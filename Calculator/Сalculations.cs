using System;
namespace Calculator
{
    public class Сalculations
    {
        
        Storage storage = new Storage();
        
        public double Sum(double x)
        {
            storage.result += x;
            return storage.result;            
            
        }
        public double Substract(double x)
        {
            storage.result -= x;            
            return storage.result;            
        }
        public double Multiply(double x)
        {
            storage.result *= x;
            return storage.result;
            
        }
        public double Divide(double x)
        {
            if (x == 0)
                throw new Exception("Деление на 0");
            else
            {
                storage.result /= x;
                return storage.result;
            }
        }
        public double Pow(double x)
        {
            storage.result = Math.Pow(storage.result, x);
            return storage.result;            
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
            if (x % 1 == 0 && x >= 0)
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
            else
            {
                throw new Exception("Число должно быть целое и больше или равно 0");
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
