using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalProgram
{
    public class Fibonacci
    {
        public static void FibonacciWithRecursive()
        {
            Console.Write("Enter the number of elements to Print : ");
            int numberOfElements = int.Parse(Console.ReadLine());

            int firstNum = 0, secondNum = 1;

            FibSeries(firstNum, secondNum, 1, numberOfElements);
        }

        private static void FibSeries(int first, int second, int counter, int number)
        {
            Console.Write(first + " ");
            if (counter < number)
            {
                FibSeries(second, first + second, counter + 1, number);
            }
        }

        public static void FibonacciWithIterative()
        {
            Console.Write("Enter the number of elements to Print : ");
            int numberOfElements = int.Parse(Console.ReadLine());

            int firstNum = 0, secondNum = 1, nextNum = 0;

            Console.Write(firstNum + " " + secondNum + " ");

            for (int i = 2; i < numberOfElements; i++)
            {
                nextNum = firstNum + secondNum;
                Console.Write(nextNum + " ");
                firstNum = secondNum;
                secondNum = nextNum;
            }
        }
    
        public static void NthFibNumWithrecursive()
        {
            Console.Write("Please enter the Nth number of the Fibonacci Series : ");
            int NthNumber = int.Parse(Console.ReadLine());
            NthNumber = NthNumber - 1;
            Console.WriteLine(NthFibNum(NthNumber));
        }

        private static int NthFibNum(int num)
        {
            if ((num == 0) || (num == 1))
            {
                return num;
            }

            return (NthFibNum(num - 1) + NthFibNum(num - 2));
        }

    }
}
