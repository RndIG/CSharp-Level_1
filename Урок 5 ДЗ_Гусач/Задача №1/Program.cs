using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/// <summary>
/// Игорь Гусач
/// 
/// Создать программу, которая будет проверять корректность ввода логина. Корректным
/// логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
/// или цифры, при этом цифра не может быть первой
/// </summary>
namespace Задача__1
{
    class Program
    {
        static void Main(string[] args)
        {
            string smp = "[a-z]{1,}[a-z 0-9]{1,9}";
            Regex sample = new Regex(smp);
            Console.WriteLine("Enter login :");
            string login = Console.ReadLine();
            bool check = sample.IsMatch(login);
            while (true)
                if (sample.IsMatch(login))
                { 
                    Console.Write("Correct.");
                    login = Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Write("Wrong.");
                    login = Console.ReadLine();
                }
                


            Console.ReadKey();
        }
    }
}
