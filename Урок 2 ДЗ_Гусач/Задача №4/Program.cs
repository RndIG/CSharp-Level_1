using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
///  На выходе истина, если прошел авторизацию, и ложь, если не прошел 
///  (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля,
///  написать программу: пользователь вводит логин и пароль, программа 
///  пропускает его дальше или не пропускает. 
///  С помощью цикла do while ограничить ввод пароля тремя попытками.
/// </summary>
namespace Задача__4
{
    class Program
    {   
        static bool check(string[] userCred,string[] dbCred)
        {
            if(userCred[0] == dbCred[0] && userCred[1] == dbCred[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            string[] userCred = new string[2];
            string[] dbID = new string[2];
            dbID[0] =  "root";
            dbID[1] = "GeekBrains";
            int maxTries = 3;
            int tries = 0;
            do
            {
                Console.Write("Enter login :");
                userCred[0] = Console.ReadLine();
                Console.Write("Enter password :");
                userCred[1] = Console.ReadLine();

                if (check(userCred, dbID) == true)
                {
                    Console.WriteLine("Passed");
                    break;
                }
                else if (tries == maxTries - 1)
                {
                    tries++;
                    Console.WriteLine("Try again later.");
                }
                else
                {
                    tries++;
                    Console.WriteLine("Wrong login or password, try again, you have " +(maxTries-tries)+" tries left");
                }
                
            }
            while (tries < maxTries);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
