using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Игорь Гусач
/// 
/// а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий
/// массив определенного размера и заполняющий массив числами от начального значения с
/// заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод
/// Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент
/// массива на определённое число, свойство MaxCount, возвращающее количество максимальных
/// элементов. В Main продемонстрировать работу класса.
/// б)*Добавить конструктор и методы, которые загружают данные из файла и записывают данные в
/// файл.
/// </summary>
namespace Задача__2
{
    class MyArray
    {
        
        int[] a;



        /// <summary>
        /// Создание массива из "n" элементов.
        /// </summary>
        /// <param name="n"> Количество элементов массива</param>
        public MyArray(int n)
        {
            int[] a =new int [n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = a[i] = rnd.Next();
            }
        }

        /// <summary>
        /// Создание массива из "n" элементов, с заполнением случайными числами от "min" до "max".
        /// </summary>
        /// <param name="n">Количество элементов массива.</param>
        /// <param name="min">Минимальное значение для элемента массива.</param>
        /// <param name="max">Максимальное значение для элемента массива.</param>
        public MyArray(int n, int min, int max)
        {            
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(min, max);
            }
        }



        /// <summary>
        /// Создание массива из "n" элементов, с заполнением числами от от начального значения с определенным шагом.
        /// </summary>
        /// <param name="n">Количество элементов массива.</param>
        /// <param name="starting">Начальное значаение.</param>
        /// <param name="step">Шаг изменения значений.</param>
        /// <returns></returns>
        public int[] IncrArray(int n,int starting,int step)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = starting + step * i;
            }
            return a;
        }
        /// <summary>
        /// Возвращает минимальное значение среди элементов массива.
        /// </summary>
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        /// <summary>
        /// Возвращает максимальное значение среди элементов массива.
        /// </summary>
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                    sum = sum + a[i];
                return sum;
            }
        }

        public void Inverse(int[] a)
        {
            for (int i = 0; i < a.Length; i++) a[i] = -a[i];
        }

        public void Multi(int[] a,int m)
        {
            for (int i = 0; i < a.Length; i++) a[i] = a[i]*m;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int v in a)
                str = str + v;
            return str;            
        }


        //public void Print()
       // {
        //    for (int i = 0; i < a.Length; i++)
         //   {
        //        Console.Write("{0} ", a[i]);
        //    }
       // }

        public void Change(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    a[i] = -a[i];
                }              
            }            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int min = -10000, max = 10000, n = 20;

            MyArray N = new MyArray(n, min, max);

            Console.WriteLine();


            N.ToString();
            Console.ReadKey();
        }
    }
}
