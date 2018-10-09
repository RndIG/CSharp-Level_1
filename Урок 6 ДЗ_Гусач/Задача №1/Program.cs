using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

///<summary>
///Игорь Гусач 
///
///Задачи 1 и 2
///
/// Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
/// типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и
/// функцией a*sin(x).
/// 
/// Модифицировать программу нахождения минимума функции так, чтобы можно было
/// передавать функцию в виде делегата.
/// Сделать меню с различными функциями и представить пользователю выбор, для какой
/// функции и на каком отрезке находить минимум.
/// 
/// Использовать массив (или список) делегатов, в котором хранятся различные функции.
/// *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она
/// возвращает минимум через параметр.
/// 
///</summary>>







/// <summary>
/// Делегат методов функций.
/// </summary>
/// <param name="x">Аргумент функции.</param>
/// <param name="a">Параметр функции.</param>
/// <returns></returns>
public delegate double FD(double x, double a);


namespace Задачи__1_2__
{
    class Program
    {
        /// <summary>
        /// Функция.
        /// </summary>
        /// <param name="x">Аргумент функции.</param>
        /// <param name="a">Параметр функции.</param>
        /// <returns></returns>

        public static double F1(double x,double a)
        {
            return a*x * x - 50 * x + 10;
        }

        /// <summary>
        /// Функция.
        /// </summary>
        /// <param name="x">Аргумент функции.</param>
        /// <param name="a">Параметр функции.</param>
        /// <returns></returns>
        public static double Prbl(double x,double a)
        {
            return a * x * x;
        }

        /// <summary>
        /// Функция.
        /// </summary>
        /// <param name="x">Аргумент функции.</param>
        /// <param name="a">Параметр функции.</param>
        /// <returns></returns>
        public static double Sin(double x , double a)
        {
            return a * Math.Sin(x);
        }
        

        /// <summary>
        /// Метод выводит на экран таблицу значений функции.
        /// </summary>
        /// <param name="F">Функция.</param>
        /// <param name="x">Аргумент функции/начальное значение функции.</param>
        /// <param name="a">Параметр Функции.</param>
        /// <param name="b">Крайнее значение функции.</param>
        public static void Table(FD F,double x, double a, double b)
        {
            Console.WriteLine("______X____________Y______");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000}  |  {1,8:0.000}  |",x,F(x,a));
                x = x + 1;
            }
            Console.WriteLine("__________________________");
        }


        /// <summary>
        /// Метод сохраняющий таблицу значений функции в .bin файл.
        /// </summary>
        /// <param name="F">Функция</param>
        /// <param name="a">Параметр функции.</param>
        /// <param name="min">Минимальное значение аргумента.</param>
        /// <param name="max">Максимальное значение аргумента.</param>
        /// <param name="step">Шаг.</param>
        /// <param name="fileName">Имя файла/путь к файлу для сохранения.</param>
        public static void SaveFunc(FD F,double a, double min, double max, double step, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = min;
            while (x <= max)
            {
                bw.Write(F(x,a));
                x = x + step;
            }
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Метод считывает таблицу значений из файла и возвращает минимальное.
        /// </summary>
        /// <param name="fileName">Имя файла/путь к файлу для чтения.<</param>
        /// <returns></returns>
        public static double LoadMin(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            double minimum = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length/sizeof(double); i++)
            {
                d = br.ReadDouble();
                if (d < minimum) minimum = d;
            }
            br.Close();
            fs.Close();
            return minimum;
        }

        /// <summary>
        /// Метод определяющий минимум среди заданных точек функции в пределах min/max с шагом step
        /// </summary>
        /// <param name="F">Функция</param>
        /// <param name="a">Параметр функции.</param>
        /// <param name="min">Минимальное значение аргумента.</param>
        /// <param name="max">Максимальное значение аргумента.</param>
        /// <param name="step">Шаг.</param>
        /// <returns></returns>
        public static double FMin(FD F, double a, double min, double max, double step)
        {
            double minimum = double.MaxValue;
            int q = Convert.ToInt32((max - min) / step);
            double x = min;
            for (int i = 0; i < q; i++)
            {
                if (F(x, a) < minimum) minimum = F(x, a);
                x = x + step;
            }
            return minimum;
        }
        
        /// <summary>
        /// Метод определяющий параметры работы программы по вычислению минимума функции в заданных пределах.
        /// </summary>
        /// <param name="F">Функция.</param>
        public static void Def(FD F)
        {
            double x=0, a=0, min=0, max=0, step=0;
            double number;
            Console.WriteLine("Введите минималное и максимально значение аргумента функции:");
            
            do 
            {
                Console.Write("min =");
                if (Double.TryParse(Console.ReadLine(), out number))
                {
                    min = number;
                    break;
                }
                else Console.Write("Введите число! \nmin =");
            } while (!Double.TryParse(Console.ReadLine(), out number));
                        
            
            do
            {
                Console.Write("max =");
                if (Double.TryParse(Console.ReadLine(), out number))
                {
                    max = number;
                    break;
                }
                else Console.Write("Введите число! \nmax =");
            } while (!Double.TryParse(Console.ReadLine(), out number));

            
            do
            {
                Console.Write("Введите  а=");
                if (Double.TryParse(Console.ReadLine(), out number))
                {
                    a = number;
                    break;
                }
                else Console.Write("Введите число! \nа=");
            } while (!Double.TryParse(Console.ReadLine(), out number));

            
            do
            {
                Console.Write("Введите шаг :");
                if (Double.TryParse(Console.ReadLine(), out number))
                {
                    step = number;
                    break;
                }
                else Console.Write("Введите число! \nВведите шаг :");
            } while (!Double.TryParse(Console.ReadLine(), out number));
            Console.WriteLine("Минимальное значение на данном отрезке =" + FMin(F, a, min, max, step) + "\n\n");
        }


        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Для выбора \n F= a*x^2    нажмите 1 \n F= a*sin(x) нажмите 2\n Для выхода нажмите Q.");
                string param = Console.ReadLine();
                if (param== "1") Def(Prbl);
                else if (param == "2") Def(Sin);
                else if (param == "3") Def(F1);
                else if (param == "q") return;
                else Console.WriteLine("Не верный выбор");
            }
        //Console.ReadKey();


         //SaveFunc(Prbl,0.2, -100, 100, 0.5,"Data.bin");
         //Console.WriteLine(LoadMin("Data.bin"));
            

         //Table(Sin, -10, 2,10);


         //Table(Prbl, -10, 0.2, 10);



                
        }
    }
}
