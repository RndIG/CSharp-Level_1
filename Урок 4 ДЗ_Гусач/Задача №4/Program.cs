using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Игорь Гусач
/// 
/// Реализовать класс для работы с двумерным массивом. 
/// Реализовать конструктор,заполняющий массив случайными числами. 
/// Создать методы, которые возвращают сумму всех элементов массива, 
/// сумму всех элементов массива больше заданного, 
/// свойство, возвращающее минимальный элемент массива, 
/// свойство, возвращающее максимальный элемент массива,
/// метод, возвращающий номер максимального элемента массива (через параметры, используя
/// модификатор ref или out).
/// 
/// Добавить конструктор и методы, которые загружают данные из файла и записывают данные
/// в файл.
/// 
/// Обработать возможные исключительные ситуации при работе с файлами.
/// </summary>
namespace Задача__4
{
    /// <summary>
    /// Класс для работы с файлами(на примере файла с логинами и паролями).
    /// </summary>
    class UserCredentials
    {

        public static int a = 4;
       

        string[][] data=new string [a][];
                     
        public UserCredentials()
        {
            string[][] data;             
        }


        public UserCredentials(string pathToFile)
        {
            
            int i = 0;            
            string[] arrDB = File.ReadAllLines(pathToFile);
            foreach (var item in arrDB)
            {                
                string[] temp = item.Split(' ');
                data[i] = temp;                
                i++;
            }

        }
        public void show()
        {
            foreach(string[] item in data)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item[i]);
                }     
            } 
        }
        public override string ToString()
        {
            string str = "";
            foreach (string[] v in data)
                str = str + v[0]+" "+v[1]+"\n";
            return str;
        }
        public void Copy(string Path)
        {
            string output = "";
            using (StreamWriter sw = new StreamWriter(Path, false, System.Text.Encoding.Default))
                foreach (string[] item in data)
                {
                    output = item[0] + " " + item[1] + "\n";
                    {
                        sw.WriteLine(output);
                    }
                }            
        }
    }

    /// <summary>
    /// Класс двумерный массив
    /// </summary>
    class TestArray
    {
        int columns;
        int rows;
        int[,] a;

        //public TestArray()
        //{           
        //    a = new int[1,1];
        //}

        public TestArray(int c,int r)
        {
            columns = c;
            rows = r; 
            a = new int[r, c];
                       
        }
        
        /// <summary>
        /// Двумерный массив с заданными параметрами. 
        /// </summary>
        /// <param name="c">Количество столбцов.</param>
        /// <param name="r">Количество строк.</param>
        /// <param name="min">Минимальное значение элемента.</param>
        /// <param name="max">Максимальное значение элемента.</param>
        public TestArray(int c, int r, int min, int max)
        {
            columns = c;
            rows = r;
            a = new int[r, c];
            Random rnd = new Random();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    a[i, j] = rnd.Next(min, max+1);
                }

            }
        }

        public string MaxIndex()
        {
            int ind1 = 0, ind2 = 0;
            string str = "";
            int compare = Max();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    if (a[i, j]==compare)
                    {                        
                        ind1 = i; ind2 = j;
                        str = str + "[" + ind1.ToString() + "," + ind2.ToString() + "] ";
                    }
                }
            return str ="Наибольшее значение имеют элементы : "+ str;

        }



        /// <summary>
        /// Сумма элементов массива.
        /// </summary>
        /// <returns></returns>
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    sum = sum + a[i, j];
                }
            return sum;
        }

        /// <summary>
        /// Сумма элеиентов больше заданного.
        /// </summary>
        /// <returns></returns>
        public int SumG(int b)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    if(a[i,j]>b)sum = sum + a[i, j];
                }
            return sum;
        }

        /// <summary>
        /// Минимальный элемент массива.
        /// </summary>
        public int Min()
        {
            int min = a[0, 0];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    if (min > a[i, j]) min = a[i, j];
                }
            return min;
        }

        /// <summary>
        /// Максимальный элемент массива.
        /// </summary>
        public int Max()
        {
            int max = a[0, 0];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    if (max < a[i, j]) max = a[i, j];
                }
            return max;
        }

        /// <summary>
        /// Вывод массива на экран.
        /// </summary>
        public void Show()
        {
            string s="";
            for (int i = 0; i < rows; i++)
            {                
                for (int j = 0; j < columns; j++)
                {
                    s = s + a[i, j] + " ";
                }
                s = s + "\n";                
            }
            Console.Write(s);
        }

        
    }
    class Program
    {
        
        static void Main()
        {

            TestArray v = new TestArray(20, 7,10,21);

            v.Show();                       

            
            Console.WriteLine(v.MaxIndex());

            Console.WriteLine(v.Sum());

            UserCredentials localDB = new UserCredentials("Data.txt");

            Console.WriteLine(localDB);

            localDB.Copy("DataCopy.txt");



            
            Console.ReadKey();

        }
    }
}
