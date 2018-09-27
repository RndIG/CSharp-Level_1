using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region
/*Игорь Гусач 
 * Написать программу, которая подсчитывает расстояние между точками с координатами x1,y1 и x2,y2
 * по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
 * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой); 
 * 
 * *Выполнить задание, оформив вычисления расстояния между точками в виде метода. 
 *  
*/
#endregion
namespace Задача___3
{
    
    class Program
    {
        static double Distance(double x1, double y1, double x2, double y2 )
        {
                     
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return r;
        }

        static void Main()
        {
            Console.Write("Введите координату по X первой точки :");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату по Y первой точки :");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату по X второй точки :");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату по Y второй точки :");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Расстояние между точками :");
            Console.Write("{0:F2}" , Distance(x1,y1,x2,y2));

           Console.ReadKey();          

        }
        
    }
}
