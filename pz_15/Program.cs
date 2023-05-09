using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст. Для завершения ввода введите пустую строку:");
            string input = "";
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "")
                {
                    break;
                }
                input += line + "\n";
            }

            int count = CountNumbers(input);
            Console.WriteLine($"Количество чисел в тексте: {count}");
            Console.WriteLine("Содержимое файла:");
            Console.WriteLine(input);

            Console.ReadLine();
        }

        static int CountNumbers(string input)
        {
            int count = 0;
            foreach (string word in input.Split(' ', '\t', '\n', '\r'))
            {
                if (int.TryParse(word, out int number))
                {
                    count++;
                }
            }
            return count;
        }
        
    }
}
