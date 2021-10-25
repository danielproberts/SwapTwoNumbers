using System;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 2;
            int val2 = 5;
            Console.WriteLine("Val1 = " + val1);
            Console.WriteLine("Val2 = " + val2);
            Swap(ref val1, ref val2);

            Console.WriteLine();
            Console.WriteLine("After Swap: ");
            Console.WriteLine("Val1 = " + val1);
            Console.WriteLine("Val2 = " + val2);

            Console.ReadKey();
        }

        static void Swap(ref int num1, ref int num2)
        {
            int tempNum;
            tempNum = num1;
            num1 = num2;
            num2 = tempNum;
        }
    }
}
