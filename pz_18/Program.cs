using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_18
{
    internal class Program
    {
        enum Marks
        {
            Отлично = 5,
            Хорошо = 4,
            Удовлетворительно = 3,
            Неудовлетворительно = 2,
            ОченьПлохо = 1
        }
        static void Main(string[] args)
        {
            int mark;

            Console.Write("Введите оценку по пятибалльной шкале: ");
            if (int.TryParse(Console.ReadLine(), out mark))
            {
                switch (mark)
                {
                    case (int)Marks.Отлично:
                        Console.WriteLine("Отлично");
                        break;
                    case (int)Marks.Хорошо:
                        Console.WriteLine("Хорошо");
                        break;
                    case (int)Marks.Удовлетворительно:
                        Console.WriteLine("Удовлетворительно");
                        break;
                    case (int)Marks.Неудовлетворительно:
                        Console.WriteLine("Неудовлетворительно");
                        break;
                    case (int)Marks.ОченьПлохо:
                        Console.WriteLine("Очень плохо");
                        break;
                    default:
                        Console.WriteLine("Некорректное значение оценки");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректное значение оценки");
            }

            Console.ReadKey();
        }
    }
}
