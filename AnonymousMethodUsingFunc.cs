using System;

namespace AnonymousMethodUsingFunc
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Func<int, int,int> addNum = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber + secondNumber;
            };

            Func<int, int, int> subtractNum = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber - secondNumber;
            };

            Func<int, int, int> productNum = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber * secondNumber;
            };

            Func<int, int, int> divisionNum = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber / secondNumber;
            };

            Calculator(addNum,10, 3);

            Calculator(subtractNum, 10, 3);

            Calculator(productNum, 10, 3);

            Calculator(divisionNum, 10, 3);

        }
        static void Calculator(Func<int,int,int> cal,int firstNumber,int secondNumber)
        {
            Console.WriteLine(cal(firstNumber, secondNumber));
        }
        
    }
}
