using System;

namespace AnonymousMethodActionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> addNum = delegate (int firstNumber, int secondNumber)
            {
                Console.WriteLine( firstNumber + secondNumber);
            };

            Action<int, int> subtractNum = delegate (int firstNumber, int secondNumber)
            {
                Console.WriteLine(firstNumber - secondNumber);
            };

            Action<int, int> productNum = delegate (int firstNumber, int secondNumber)
            {
                Console.WriteLine(firstNumber * secondNumber);
            };

            Action<int, int> divisionNum = delegate (int firstNumber, int secondNumber)
            {
                Console.WriteLine(firstNumber / secondNumber);
            };

            Calculator(addNum+=subtractNum+=productNum+=divisionNum,10, 3);

       
    }
    static void Calculator(Action<int, int> cal, int firstNumber, int secondNumber)
    {
        cal(firstNumber, secondNumber);
    }
}
}
