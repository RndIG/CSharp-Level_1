using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Игорь Гусач
/// 
/// Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
/// Хорошим называется число, которое делится на сумму своих цифр. 
/// Реализовать подсчет времени выполнения программы, используя структуру DateTime.
/// 
/// </summary>
namespace Задача__6
{
    class Program
    {
        static int Sum(int num)
        {
            if (num != 0)
            {
                return (num % 10 + Sum(num / 10));
            }
            else
            {
                return 0;
            }
        }

        

        static bool Check(int number)
        {
            bool answer;
            if (number % Sum(number) == 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }

        static int[] GoodNumbers(int maxNumber)
        {            
            int j = 0;
            int z = 0;

            for (int i = 1; i <= maxNumber; i++)
            {
                if (Check(i) == true)
                {
                    j++;                    
                }
            }

            int[] goodNumbers = new int[j];

            for (int i = 1; i <= maxNumber; i++)
            {                
                if (Check(i) == true)
                {                    
                    goodNumbers[z] = i;
                    z++;
                }                    
            }
            return goodNumbers;
        }


        static int GoodNumbersQ(int maxNumber)
        {
            int j = 0;            

            for (int i = 1; i <= maxNumber; i++)
            {
                if (Check(i) == true)
                {
                    j++;
                }
            }            
            return j;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите максимальное число (только INT) :");
            int max = int.Parse(Console.ReadLine());                     

            DateTime start = DateTime.Now;

            Console.Write("Количество хороших чисел :" + GoodNumbersQ(max));

            DateTime finish = DateTime.Now;
            
            Console.Write("Время расчета :" + (finish - start));
           
            Console.ReadKey();
        }
    }
}
