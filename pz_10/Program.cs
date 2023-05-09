using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес электронной почты: ");
            string email = Console.ReadLine();

            bool validmail = Regex.IsMatch(email.Split('@')[0], @"^[a-zA-Z0-9!\-_\.]+$");

            bool validdomen = email.EndsWith("@gmail.com") || email.EndsWith("@yandex.ru") || email.EndsWith("@mail.ru");

            bool at = email.Contains("@");

            if (validmail && validdomen && at)
            {
                Console.WriteLine("Почта написана правильно");
            }
            else 
            {
                Console.WriteLine("Почта написана некорректно");
            }
            Console.ReadKey();  
        }
    }
}
