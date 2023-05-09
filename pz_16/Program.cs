using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "test.txt";

            // Создаем текстовый файл и записываем в него произвольный текст
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("строка");
                writer.WriteLine("вторая строка ");
                writer.WriteLine("третья строка");
            }

            // Считаем количество строк, символов и слов в файле
            int lineCount = 0;
            int charCount = 0;
            int wordCount = 0;

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;
                    charCount += line.Length;
                    wordCount += line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    Console.WriteLine($"Строка {lineCount}: {line.Length} символов, {line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length} слов");
                }
            }

            Console.WriteLine($"Файл содержит {lineCount} строк, {charCount} символов и {wordCount} слов.");

            Console.ReadLine();
        }
    }
}
