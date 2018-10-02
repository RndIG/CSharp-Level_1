using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// Игорь Гусач
/// 
/// а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
/// Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму 
/// вывести на экран, используя tryParse;
/// б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
/// При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
/// 
/// </summary>
namespace Задача__2
{
    class Program
    {
        static void Main()
        {
            bool isNumber;
            string input;
            int sum = 0;
            Console.WriteLine("Input number :");
            do
            {
                input = Console.ReadLine();
                isNumber = int.TryParse(input,out int number);
                if (isNumber)
                {
                    if (number % 2 != 0 && number >0){sum = sum + number;}
                }
                else
                {
                    Console.WriteLine("Incorrect input, try to input intger nubers instead");
                    input = Console.ReadLine();
                    int.TryParse(input, out int number2);
                    if (number2 % 2 != 0 && number2 > 0) { sum = sum + number2; }
                }
            }
            while ((isNumber && Convert.ToInt32(input) != 0)|| !isNumber);

            Console.WriteLine("Sum of positive odd numbers in the list :" + sum);
            Console.ReadKey();
        }
    }
}
