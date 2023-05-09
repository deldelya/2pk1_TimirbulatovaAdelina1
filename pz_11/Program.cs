using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "моя почта dskk@gmail.ru " + "чай" + "мой второй адрес eeenn33@mail.ru";

            
            MatchCollection matches = Regex.Matches(text, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b");

            string[] Login = new string[matches.Count]; // массив для хранения имен пользователей

            for (int i = 0; i < matches.Count; i++) //извлекаем логин из адреса
            {
                string[] parts = matches[i].Value.Split('@');
                Login[i] = parts[0];
            }

            Console.WriteLine("Имена пользователей:");
            foreach (string userName in Login)
            {
                Console.WriteLine(userName);
            }

            Console.ReadLine();
        }
    }
}
