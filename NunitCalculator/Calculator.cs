using System;
using System.Security;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int Add(int firtsNumber, int secondNumber)
        {
            return firtsNumber + secondNumber;
        }
        public int Subtraction(int firtsNumber, int secondNumber)
        {
            return firtsNumber - secondNumber;
        }
        public int Multiplication(int firtsNumber, int secondNumber)
        {
            return (firtsNumber * secondNumber);
        }
        public int Division(int firtsNumber, int secondNumber)
        {
            return firtsNumber / secondNumber;
        }
        public int Modulus(int firtsNumber, int secondNumber)
        {
            return firtsNumber % secondNumber;
        }
        public int CheckSymbol(int first, int second, string sign)
        {
            if (sign == "+")
            {
               
               return Add(first, second);
            }
            if (sign == "-")
            {
                return Subtraction(first, second);
            }
            if(sign == "*")
            {
                return Multiplication(first, second);
            }
            if(sign == "/")
            {
                return Division(first, second);
            }
            if(sign == "%")
            {
                return Modulus(first, second);
            }

            throw new Exception ("Sign cann't be found");
        }
    }
}