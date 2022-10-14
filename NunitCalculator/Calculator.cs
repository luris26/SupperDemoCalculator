using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
        public int Subtraction()
        {
        
            return FirstNumber - SecondNumber;
        }
        public int Multiplication()
        {
            return FirstNumber * SecondNumber;
        }

    }
}