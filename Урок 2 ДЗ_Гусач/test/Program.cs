using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static int Sum1(string input)
        {
            //string inputStr = Convert.ToString(input);
            int res = 0;
            for (int i = 0; i < input.Length; i++)
            {
                res = res + Convert.ToInt32(input[i].ToString());
            }
            return res;
        }
        static int sum2(int num)
        {
            if (num != 0)
            {
                return (num % 10 + sum2(num / 10));
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("str");
            string value1 = Console.ReadLine();
            int value2 = Int32.Parse(value1);
            DateTime start1 = DateTime.Now;
            Console.WriteLine(Sum1(value1));
            DateTime finish1 = DateTime.Now;
            DateTime start2 = DateTime.Now;
            Console.WriteLine(sum2(value2));
            DateTime finish2 = DateTime.Now;
            Console.WriteLine(start1-finish1);
            Console.WriteLine(start2- finish2);
            Console.ReadLine();
        }
    }
}
