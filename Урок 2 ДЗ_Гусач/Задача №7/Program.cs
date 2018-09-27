using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// Игорь Гусач
/// 
/// a) Разработать рекурсивный метод, который выводит на экран числа от a до b 
/// 
/// 
/// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
/// 
/// 
/// </summary>
namespace Задача__7
{
    class Program
    {
        static string List(int a, int b)
        {
            string output;
            if (a < b)
            {
                output = Convert.ToString(a) + " " + List(a + 1, b);
            }
            else
            {
                return Convert.ToString(b);
            }
            return output;
        }
        
        static int sum(int a,int b)
        {
            int res;
            if (a < b)
            {
                res = a + sum(a + 1, b);
            }
            else
            {
                return b;
            }
            return res;
        }



        static void Main()
        {
            Console.Write("Enter first number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter last number :");
            int b = Convert.ToInt32(Console.ReadLine());

            
            Console.Write(List(a, b));
            Console.Write(sum(a,b));
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
