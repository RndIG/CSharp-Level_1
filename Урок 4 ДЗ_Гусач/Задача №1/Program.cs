using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Игорь Гусач
///  
/// Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые
/// значения от –10 000 до 10 000 включительно. Написать программу, позволяющую найти и
/// вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. В
/// данной задаче под парой подразумевается два подряд идущих элемента массива.
/// 
/// </summary>
namespace Задача__1
{
    class Program
    {
        static int[] newArray(int n,int min,int max)
        {
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(min, max);
            }
            return a;
        }
        static int coupleCounter(int[] a)
        {
            int count=0;
            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i]%3==0 || a[i + 1] % 3 == 0)
                {
                    count = count + 1;
                }                
            }
            return count;
        }
        static void Main()
        {
            int min = -10000, max = 10000, n = 20;

            int [] array = newArray(n, min, max);

            Console.WriteLine(coupleCounter(array));
            Console.ReadKey();
            
        }
    }
}
