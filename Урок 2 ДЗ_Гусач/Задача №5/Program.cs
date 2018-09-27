using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и 
///  сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
///  б) Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
///  Индекс массы тела I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
///  Индекс массы тела	Соответствие между массой человека и его ростом
///  16 и менее     Выраженный дефицит массы тела         
///  16—18,5	    Недостаточная(дефицит) масса тела
///  18,5—24,99	    Норма
///  25—30	        Избыточная масса тела(предожирение)
///  30—35	        Ожирение
///  35—40	        Ожирение резкое
///  40 и более     Очень резкое ожирение
/// </summary>
namespace Задача__5
{
    class Program
    {
        static int BMI(int weight,int height)
        {
            int bmi = weight*10000/(height*height);
            return bmi;
        }

        static string tableValue(int bmi)
        {
            string tableCategory;
            if(bmi < 16)
            {
                tableCategory = "выраженный дефицит массы тела ";
            }
            else if (bmi >= 16 && bmi < 18.5)
            {
                tableCategory = "недостаточная(дефицит) масса тела";
            }
            else if(bmi >= 18.5 && bmi < 25)
            {
                tableCategory = "норма";
            }
            else if (bmi >= 25 && bmi <30)
            {
                tableCategory = "избыточная масса тела(предожирение)";
            }
            else if (bmi >= 30 && bmi < 35)
            {
                tableCategory = "ожирение";
            }
            else if (bmi >= 35 && bmi < 40)
            {
                tableCategory = "резкое ожирение ";
            }
            else 
            {
                tableCategory = "Очень резкое ожирение";
            }

            return tableCategory;

        }

        static int BMIdiff(int bmi,int weight)
        {
            int diff = 0;
            int targetWeight = weight;
            int refBMI=22;
            if (bmi < 19)
            {
                refBMI = 19;
            }
            else if (bmi >= 25)
            {
                refBMI = 25;
            }
            else
            {
                return diff;
            }

            targetWeight = (refBMI *100/ bmi) * weight/100;
            diff = targetWeight - weight;
            return diff;
        }

        static void Main()
        {

            Console.WriteLine("Введите свой рост в сантиметрах : ");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой вес в килограмах : ");
            int weight = Int32.Parse(Console.ReadLine());

            int bmi = BMI(weight, height);
            int diff = BMIdiff(bmi, weight);

            Console.WriteLine("Ваш индекс массы тела : " + bmi + "\n У вас наблюдается " + tableValue(bmi));
            if (diff < 0)
            {
                Console.WriteLine("Вам необходимо сбросить " + Math.Abs(diff) + " кг");
            }
            else if(diff > 0)
            {
                Console.WriteLine("Вам необходимо набрать " + diff + " кг");
            }

            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
