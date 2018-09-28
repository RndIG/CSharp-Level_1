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
        public Fraction Simplify(Fraction)
        {
            int i =
        }

    }
    class Program
    {
        static void Main()
        {
            




        }
    }
}
