using System;

namespace MulticastDelegateApp
{
    public delegate void Calculator(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = AddNum;
            calc += MultiplyNum;
            Console.Write(" Please Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            calc(firstNum, secondNum);
        }
        static void AddNum(int num1, int num2)
        {
            Console.WriteLine($"Sum is: {num1 + num2}");
        }
        static void MultiplyNum(int num1, int num2)
        {
            Console.WriteLine($"Multiplication is: {num1 * num2}");
        }
    }
}
