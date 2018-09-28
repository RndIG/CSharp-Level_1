using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// Игорь Гусач 
/// 
/// 
/// Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса. 
/// 
/// 
/// </summary>
namespace Задача__1
{
    class Complex
    {
        double re;
        double im;
        

        public Complex()
        {
            re = 0;
            im = 0;
        }
        public Complex(double re,double im)
        {
            this.re = re;
            this.im = im;
        }

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        public Complex Multiply(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im*x2.re + re*x2.im;
            x3.re = re*x2.re + im*x2.im;
            return x3;
        }
        public Complex Divide(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = (im*x2.re - re*x2.im) / (x2.re*x2.re + x2.im*x2.im);
            x3.re = (re*x2.re + im*x2.im) / (x2.re*x2.re + x2.im*x2.im);
            return x3;
        }
        public double Re
        {
            get { return re; }
            set { re = value; }
        }
        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
                else im = -1 * value;
                
            }
        }
        public  string toString()
        {            
            return re.ToString("F2") + " + " + im.ToString("F2") + "i";
            
        }
    }
    class Program
    {
        static void Define(Complex Input)
        {            
            Console.Write("Enter real part of complex number :");
            Double.TryParse(Console.ReadLine(), out double nRe);
            Input.Re = nRe;
            Console.Write("Enter imaginary part of complex number :");
            Double.TryParse(Console.ReadLine(), out double nIm);
            Input.Im = nIm;            
        }

        static void Main(string[] args)
        {



            Complex P;
            P = new Complex(1,1);
            
            Complex Q;
            Q = new Complex(1, 1);

            Complex W;
            W = new Complex(1, 1);

            Console.WriteLine("Define your complex number P:\n");
            Define(P);

            Console.WriteLine("\n\nDefine your complex number Q:\n");
            Define(Q);

            Console.WriteLine("\nP = " + P.toString());
            Console.WriteLine("\nQ = " + Q.toString());

            W = P.Plus(Q);
            Console.WriteLine("\n\n\nP + Q = " + W.toString());
            W = P.Minus(Q);
            Console.WriteLine("P - Q = " + W.toString());
            W = P.Divide(Q);
            Console.WriteLine("P / Q = " + W.toString());
            W = P.Multiply(Q);
            Console.WriteLine("P * Q = " + W.toString());
            Console.ReadKey();
            Console.WriteLine("Press any key for exit ");
        }
    }
}
