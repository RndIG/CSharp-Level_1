using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/// <summary>
/// Разработать класс Message, содержащий следующие статические методы для обработки текста:
/// а) Вывести только те слова сообщения, которые содержат не более n букв.
/// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
/// в) Найти самое длинное слово сообщения.
/// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
/// </summary>
namespace Задача__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Text.txt");
            
            msg.onScreen();
            Console.WriteLine("\n");
            msg.Longest();
            Console.WriteLine("\n");
            msg.notMoreThan(8);
            Console.ReadKey();

        }
    }
}
