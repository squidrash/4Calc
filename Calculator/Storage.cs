using System;
namespace Calculator
{
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
        private double SecondMemory { get; set; }
        public double secondMemory
        {
            get
            {
                return SecondMemory;
            }
            set
            {
                SecondMemory = value;
            }
        }
        private string SecondMemoryOperation { get; set; }
        public string secondMemoryOperation
        {
            get
            {
                return SecondMemoryOperation;
            }
            set
            {
                SecondMemoryOperation = value;
            }
        }

    }
}
