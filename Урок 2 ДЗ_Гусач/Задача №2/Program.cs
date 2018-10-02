using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Игорь Гусач
/// 
/// Написать метод подсчета количества цифр числа.
/// 
/// </summary>
namespace Задача__2
{
    class Program
    {   
        static int digitsInt(int input)
        {            
            int j = 0;
            while (input >= 10)
            {
                input = input / 10;
                j++;
            }
            if (input < 10)
            {
                j++;
            }
            return j;
        }
        
        static void Main()
        {                      
            Console.Write("Введите число для обработки :");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Результат :" + digitsInt(number));
            Console.ReadKey();
        }
    }
}
