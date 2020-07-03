using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapVariable.ExecuteSwapUsingThirdVar();
            Console.WriteLine("=========================================");

            SwapVariable.SwapByMulDiv();
            Console.WriteLine("=========================================");

            SwapVariable.SwapByAddMinus();
            Console.WriteLine("=========================================");

            SwapVariable.SwapStringWithoutUsingThirdVar();
            Console.WriteLine("=========================================");

            Fibonacci.FibonacciWithIterative();
            Console.WriteLine("\n=========================================");

            Fibonacci.FibonacciWithRecursive();
            Console.WriteLine("\n=========================================");

            Console.ReadLine();
        }
    }
}
