using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalProgram
{
    public class Comparison
    {
        public static void Test()
        {
            // input 
            Console.WriteLine("Enter two number split by space.");

            string[] origin = Console.ReadLine().Split(' ');
            int[] OriginInts = Array.ConvertAll(origin, int.Parse);

            Console.WriteLine("Enter line count.");
            int cnt = Convert.ToInt32(Console.ReadLine());

            List<int[]> input = new List<int[]>();

            for (int i = 0; i < cnt; i++)
            {
                input.Add(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
            }

            // compare
            List<string> result = new List<string>();
            for (int i = 0; i < cnt; i++)
            {
                result.Add(Compare(OriginInts, input[i]));
            }

            // output
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        private static string Compare(int[] origin, int[] input)
        {
            // compare 1st room
            if (origin[0] > input[0])
            {
                return "High";
            }

            if (origin[0] < input[0])
            {
                return "Low";
            }

            // compare 2nd room
            if (origin[1] > input[1])
            {
                return "Low";
            }

            if (origin[1] < input[1])
            {
                return "High";
            }

            return string.Empty;
        }

    }
}
