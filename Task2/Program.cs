using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double _a;
                double _b;
                double _c;
                Console.WriteLine("Для создания треугольника введите длины его сторон");
                _a = GetValueFromConsole("Сторона А");
                _b = GetValueFromConsole("Сторона B");
                _c = GetValueFromConsole("Сторона С");
                if (!Triangle.CanBeTriangle(_a, _b, _c))
                {
                    Console.WriteLine("Не соблюдено правило! Каждая сторона треугольника должна быть меньше сумм двух других сторон");
                    Console.WriteLine();
                    continue;
                }
                Triangle triagle = new Triangle(_a, _b, _c);
                Console.WriteLine("Площадь треугольника: {0}", triagle.GetArea());
                Console.WriteLine("Периметр треугольника: {0}", triagle.GetPerimeter());
                Console.ReadKey();
            }
        }


        /// <summary>
        /// Запрос и получение значения с консоли
        /// </summary>
        /// <param name="text">Текст для запроса значения</param>
        /// <returns></returns>
        public static double GetValueFromConsole(string text)
        {
            double _value;
            Console.WriteLine("{0}:", text);
            string value = Console.ReadLine();
            while (!Double.TryParse(value, out _value) || _value < 0)
            {
                Console.WriteLine("Неверно введено значение. {0}:", text);
                value = Console.ReadLine();
            }

            return _value;
        }
    }
}
