using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
/*Игорь Гусач 
 *  Написать программу обмена значениями двух переменных: 
 *  а) с использованием третьей переменной; 
 *  б) *без использования третьей переменной. 
 * 
 *  
*/
#endregion
namespace Задача__4
{
    class Program
    {
        static void Main()
        {
            /*
            int a;          //с дополнительной переменной
            int b; 
            int x;
            x = a;
            a = b;
            b = x;
            */

            int a = 4;
            int b = 7;
            a = a + b; //a = 11
            b = a - b; //b = 4 
            a = a - b; //a = 7

            
        }

    }
}
