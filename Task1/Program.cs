using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double _x;
            double _y;
            double _r;
            Console.WriteLine("Для создания окружности введите координаты ее центра и ее радиус.");
            _x = GetValueFromConsole("Координата X");
            _y = GetValueFromConsole("Координата Y");
            _r = GetValueFromConsole("Радиус окружности");

            Round round = new Round(_x, _y, _r);
            Console.WriteLine("Площадь круга: {0}", round.Area);
            Console.WriteLine("Длина окружности: {0}", round.LengthRound);
            Console.ReadKey();

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
            while (!Double.TryParse(value, out _value))
            {
                Console.WriteLine("Неверно введено значение. {0}:", text);
                value = Console.ReadLine();
            }
            
            return _value;
        }

    }
}
