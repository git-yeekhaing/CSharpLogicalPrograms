using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalProgram
{
    public class SwapVariable
    {
        public static void ExecuteSwapUsingThirdVar()
        {
            int num1 = 10, num2 = 20, temp = 0;
            Console.WriteLine($"Before SWapping number1= {num1}, number2 = {num2}");

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After SWapping number1= {num1}, number2 = {num2}");
        }

        public static void SwapByMulDiv()
        {
            int num1 = 10, num2 = 20;
            Console.WriteLine($"Before SWapping number1= {num1}, number2 = {num2}");

            num1 = num1 * num2; // 10*20 = 200
            num2 = num1 / num2; // 200/20 = 10 
            num1 = num1 / num2; // 200/10 = 20

            Console.WriteLine($"After SWapping number1= {num1}, number2 = {num2}");
        }

        public static void SwapByAddMinus()
        {
            int num1 = 10, num2 = 20;
            Console.WriteLine($"Before SWapping number1= {num1}, number2 = {num2}");

            num1 = num1 + num2; // 10+20 = 30
            num2 = num1 - num2; // 30 - 20 = 10
            num1 = num1 - num2;

            Console.WriteLine($"After SWapping number1= {num1}, number2 = {num2}");
        }

        public static void SwapStringWithoutUsingThirdVar()
        {
            string name1 = "Dotnet", name2 = "Tutorials";
            Console.WriteLine($"Before SWapping name1= {name1}, name2 = {name2}");

            name1 = name1 + name2;
            name2 = name1.Substring(0, (name1.Length - name2.Length));

            //name1 = name1.Substring((name2.Length), (name1.Length - name2.Length));
            name1 = name1.Substring(name2.Length);

            Console.WriteLine($"After SWapping name1= {name1}, name2 = {name2}");
        }
    }
}
