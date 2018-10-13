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
    class Message
    {
        char[][] content;
        string[] words;
        public Message()
        {
            char [][] content;

        }

        public Message(string pathToFile)
        {
            Encoding encoding = Encoding.Default;            
            string text = File.ReadAllText(pathToFile, encoding);                 
            words = text.Split(' ');
            int a = words.Length;
            content=new char [a][];
            for (int i = 0; i < a; i++)
            {
                content[i] = words[i].ToCharArray();
            }
        }

        
        public void onScreen()
        {
            for (int i = 0; i < content.Length; i++)
            {
                Console.Write(new string(content[i])+" ");
            }
            Console.WriteLine("");
            
        }
        
        public void Longest()
        {           
            int index = 0;
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i].Length > index) index = i;
            }
            Console.WriteLine(content[index]);
        }

        public void notMoreThan(int n)
        {
            string str = string.Empty;
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i].Length <= n)
                {
                    str = str +new string(content[i]) + " ";
                }
            }
            Console.WriteLine(str);
        }

        
        
    }
}
