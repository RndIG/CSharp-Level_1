using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Игорь Гусач
/// 
/// С клавиатуры вводятся числа, пока не будет введен 0.
/// Подсчитать сумму всех нечетных положительных чисел.
/// </summary>
namespace Задача__3
{
    class Program
    {
        static void Main()
        {
            string input ;           
            int sum = 0;
            Console.WriteLine("Input number :");
            do
            {
                input = Console.ReadLine();
                sum = sum + Convert.ToInt32(input);                
            }
            while (Convert.ToInt32(input) != 0);

            Console.WriteLine("Sum of odd numbers in the list :" + sum);
            Console.ReadKey();
            
        }
    }
}
