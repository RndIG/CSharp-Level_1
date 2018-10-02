using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// Игорь Гусач
/// 
/// Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
/// 
/// Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
/// 
/// Написать программу, демонстрирующую все разработанные элементы класса.
/// 
/// ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать 
/// исключение ArgumentException("Знаменатель не может быть равен 0");
/// 
/// Добавить упрощение дробей.
/// </summary>
namespace Задача__3
{
    class Fraction
    {
        int numerator;
        int denominator;

        public Fraction()
        {
            numerator = 1;
            denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                {
                    denominator = value;
                }
                else throw new Exception("Denominator sould not be equal to zero!");             

            }
        }

        

        public Fraction Multiply(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.numerator = numerator * x2.numerator;
            x3.denominator = denominator * x2.denominator;
            return x3;
        }

        public Fraction Divide(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.numerator = numerator * x2.denominator;
            x3.denominator = denominator * x2.numerator;
            return x3;
        }

        public Fraction Plus(Fraction x2)
        {
            Fraction x3 = new Fraction();
            if (x2.denominator == denominator)
            {
                x3.numerator = numerator + x2.numerator;
                x3.denominator = denominator;
            }
            else
            {
                x3.numerator = numerator * x2.denominator + denominator * x2.numerator;
                x3.denominator = denominator * x2.denominator;
            }
            return x3;
        }

        public Fraction Minus(Fraction x2)
        {
            Fraction x3 = new Fraction();
            if (x2.denominator == denominator)
            {
                x3.numerator = numerator - x2.numerator;
                x3.denominator = denominator;
            }
            else
            {
                x3.numerator = numerator * x2.denominator - denominator * x2.numerator;
                x3.denominator = denominator * x2.denominator;
            }
            return x3;
        }
        public Fraction Simplify(Fraction x)
        {
            
            int i=2,min;
            if (x.numerator < x.denominator)
            {
                min = x.numerator;
            }
            else
            {
                min = x.denominator;
            }
            while(i<=min)
            {
                if(x.numerator % i == 0 && x.denominator % i == 0)
                {
                    x.numerator = x.numerator / i;
                    x.denominator = x.denominator / i;
                }
                else
                {
                    i++;
                }
            }
            return x;
        }
        public string Show()
        {
            string print = numerator.ToString() + "/" + denominator.ToString();
            return print;
        }


    }
    class Program
    {

        static void Define(Fraction Input)
        {
            Console.Write("Enter numerator  of fraction :");
            Int32.TryParse(Console.ReadLine(), out int n);
            Input.Numerator = n;
            Console.Write("Enter denominator of fraction :");
            Int32.TryParse(Console.ReadLine(), out int d);
            Input.Denominator = d;
        }
        static void Main()
        {
            Fraction L; 
            L = new Fraction(1,1);
            Console.WriteLine("Fraction L");
            Define(L);

            Fraction M;
            M = new Fraction(1,1);
            Console.WriteLine("Fraction M");
            Define(M);

            Fraction P;
            P = new Fraction(1, 1);

            Console.WriteLine("Fraction L :" +  L.Show() + "  Fraction M :" + M.Show());


            P = M.Plus(L);
            Console.WriteLine("L + M =" + P.Show());

            P = M.Divide(L);
            Console.WriteLine("L / M =" + P.Show());

            P = M.Multiply(L);
            Console.WriteLine("L * M =" + P.Show());

            P = P.Simplify(P);
            Console.WriteLine("Simplified L * M =" + P.Show());

            Console.ReadKey();
            Console.WriteLine("Press any key for exit ");


        }
    }
}
