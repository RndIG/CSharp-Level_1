using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
/*Игорь Гусач 
 * 
 * 
 * 6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause). 
 *
 *  
*/
#endregion

namespace Задача__6
{
    static class Tier1
    {

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
    }

    class Program
    {
        
        static void Main()
        {
        }
    }

}
