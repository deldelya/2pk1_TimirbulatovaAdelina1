using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace pz_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            string text1 = "1 RU161109-472905 PACK19697671 1 Ольга Каверзина +7 (918) 335-43-52 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, красина, Дом 3/3, Кв. 76" + "\n2 RU161110-466130 PACK19651968 1 Софья Назаретян +7 (918) 398-07-81 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, Базовская, Дом д.61\n" +
                "\n3 RU161111-260536 PACK19698066 3 Виктор Кипуров +7 (918) 441-97-56 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, Речная,Чехова , Дом 4, Кв. 52\n" + "\n4 RU161111-522664 PACK19697905 2 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19\n" +
                "\n5 RU161111-252357 PACK19697840 1 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0\r\n09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19\n" + "\n6 RU161104-298585 PACK19514804 3 Роман +7 (938) 435-93-29 Наличные Плюс 0 09:00 - 13:00\r\nКраснодар, фурманова, Дом 62 9.11\n";

            Regex regex = new Regex(@"\b([А-Я][а-я]+)\s+([А-Я][а-я]+)\b");

            // Извлекаем все совпадения
            MatchCollection matches = regex.Matches(text1);

            // Создаем массив для хранения имен и фамилий
            string[] names = new string[matches.Count];

            // Добавляем имена и фамилии в массив
            for (int i = 0; i < matches.Count; i++)
            {
                string firstName = matches[i].Groups[1].Value;
                string lastName = matches[i].Groups[2].Value;
                names[i] = firstName + " " + lastName;
            }

            // Выводим имена и фамилии
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            

            Console.WriteLine("Задание 2");

            // Путь к файлу на диске
            string filePath = "connects.log";

            // Текст для записи в файл
            string text2 = @"213.180.195.231 - - [29/Jan/2007:00:07:17 +0000] ""GET /excel/lsn015.html HTTP/1.1"" 200 18918 ""-"" ""YaDirectBot/1.0""
                74.6.71.37 - - [29/Jan/2007:00:13:03 +0000] ""GET /eralash HTTP/1.0"" 301 317 ""-"" ""Mozilla/5.0 (compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)""
                74.6.71.37 - - [29/Jan/2007:00:13:06 +0000] ""GET /eralash/ HTTP/1.0"" 200 12234 ""-"" ""Mozilla/5.0 (compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)""
                213.186.116.166 - - [29/Jan/2007:00:26:51 +0000] ""GET /eralash/soft/speed.zip HTTP/1.0"" 200 217872 ""-"" ""Wget/1.10.2 (Red Hat modified)""
                213.180.207.25 - - [29/Jan/2007:00:27:14 +0000] ""GET /robots.txt HTTP/1.1"" 200 54 ""-"" ""Yandex/1.01.001 (compatible; Win16; I)""";


            // Запись текста в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(text2);
            }

            string dirfile = "connects.log";

            // Чтение текста из файла
            string readtext = File.ReadAllText(dirfile);

            // Регулярное выражение для поиска IP адреса
            string ipRegex = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";

            // Поиск IP адресов
            MatchCollection readip = Regex.Matches(readtext, ipRegex);
            foreach (Match match in readip)
            {
                Console.WriteLine(match.Value);
            }

            // Регулярное выражение для поиска даты
            string dateRegex = @"\[(.*?)\]";

            // Поиск дат
            readip = Regex.Matches(text2, dateRegex);
            foreach (Match match in readip)
            {
                Console.WriteLine(match.Groups[1].Value);
            }
            Console.ReadKey();
        }
    }
}
