using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// Игорь Гусач
/// 
/// Написать метод, возвращающий минимальное из трех чисел.
/// 
/// </summary>
namespace Задача__1
{
    class Program
    {
        static int Lower(int num1, int num2,int num3)
        {
            int min =num1;

            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }
            return min;
        }

        static void Main()
        {

            Console.Write("Введите первое число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число ");
            int c = Convert.ToInt32(Console.ReadLine());


            Console.Write(Lower(a, b, c));

            Console.ReadKey();

        }
    }
}
